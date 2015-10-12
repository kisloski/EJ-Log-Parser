using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace EJ_Log_Parser
{
    public partial class LogView : Form
    {
        List<logfile> ls_files = new List<logfile>();
        List<logmsg> messages = new List<logmsg>();
        public LogView(List<logfile> files)
        {
            InitializeComponent();
            ls_files = files;
            procesor(ls_files);
            availProcessor(messages);
            foreach (logmsg msg in messages)
            {
                dg_msg.Rows.Add(msg.ID, msg.operID, msg.operDate, msg.operType, msg.loglifename);
            }
            foreach (DataGridViewRow row in dg_err.Rows)
            {
                Color back = Color.IndianRed;
                int start = Convert.ToInt16(row.Cells["cStartID"].Value);
                int end = Convert.ToInt16(row.Cells["cEndId"].Value);
                if (row.Cells["cEventType"].Value.ToString() == "TRYB OPERATORA")
                {
                    back = Color.Orange;
                }
                foreach (DataGridViewRow row1 in dg_msg.Rows)
                {
                    if (Convert.ToInt16(row1.Cells["cID"].Value) >= start && Convert.ToInt16(row1.Cells["cID"].Value) <= end)
                    {
                        row1.DefaultCellStyle.BackColor = back;
                    }
                }
            }

            groupBox1.Text += " " + messages.Count.ToString();
        }
        public List<logmsg> procesor(List<logfile> files)
        {
            int _i = 1;
            foreach (logfile flog in ls_files)
            {
                MemoryStream mStream = new MemoryStream(flog.bytes);
                StreamReader mReader = new StreamReader(mStream);
                string line = "";
                int i = _i;
                string lastLine = "";
                int myOperator = 0;
                int lastOperator = 0;
                int errOperator = 0;
                int elseOperator = 0;
                while (line != null)
                {
                    line = mReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else if (line != "" || line != null)
                    {
                        string pattern = @"\*\d{3}\*";
                        logmsg mLog = new logmsg();
                        Match match = Regex.Match(line, pattern);
                        if (match.Success)
                        {
                            mLog.ID = i;
                            mLog.operID = match.ToString();
                            myOperator = mLog.ID;
                            errOperator = mLog.ID;
                            elseOperator = mLog.ID;
                            pattern = @"\*\d{2}\/\d{2}\/\d{4}\*\d{2}\:\d{2}\*";
                            match = Regex.Match(line, pattern);
                            if (match.Success)
                            {
                                string pDate = match.ToString();
                                pDate = pDate.Replace("*", " ");
                                pDate = pDate.Trim();
                                mLog.operDate = DateTime.Parse(pDate);
                            }
                            mLog.loglifename = flog.filename;
                            messages.Add(mLog);
                            i++;
                        }
                        else if (line.Contains("POCZATEK OPERACJI") || line.Contains("KONIEC OPERACJI"))
                        {
                            elseOperator = 0;
                            if (line.Contains("POCZATEK OPERACJI"))
                            {
                                mLog = messages.Find(x => x.ID == myOperator);
                                line = line.Trim();
                                mLog.operType = line;
                                myOperator = 0;
                                lastOperator = mLog.ID;
                            }
                            else if (line.Contains("KONIEC OPERACJI") && lastOperator != 0)
                            {
                                elseOperator = 0;
                                mLog = messages.Find(x => x.ID == lastOperator);
                                logmsg mLog2 = new logmsg();
                                mLog2.ID = i;
                                mLog2.operID = mLog.operID;
                                DateTime pDate = mLog.operDate;
                                string cDate = line.Substring(0, 9);
                                DateTime cDate2 = DateTime.Parse(cDate);
                                DateTime cDate3 = new DateTime(pDate.Year, pDate.Month, pDate.Day, cDate2.Hour, cDate2.Minute, cDate2.Second);
                                mLog2.operDate = cDate3;
                                mLog2.operType = "KONIEC OPERACJI";
                                mLog2.loglifename = mLog.loglifename;
                                messages.Add(mLog2);
                                i++;
                                lastOperator = 0;
                            }
                        }
                        else if (line.Contains("WEJSCIE W TRYB OPERATORA") || line.Contains("WYJSCIE Z TRYBU OPERATORA") || line.Contains("TRYB OUT OF SERVICE") || line.Contains("TRYB IN SERVICE") && errOperator != 0)
                        {
                            elseOperator = 0;
                            mLog = messages.Find(x => x.ID == errOperator);
                            line = line.Trim();
                            mLog.operType = line;
                            errOperator = 0;
                        }
                        else if (line != null && line != "" && elseOperator != 0 )
                        {
                            mLog = messages.Find(x => x.ID == elseOperator);
                            line = line.Trim();
                            mLog.operType = line;
                            elseOperator = 0;
                        }
                    }
                    lastLine = line;
                }
                _i = i;
            }
            int k = 1; // breakpoint
            k = k + 1; // breakpoint
            return messages;
        }
        public void availProcessor(List<logmsg> messages)
        {
            int pID = 1;
            foreach (logmsg msg in messages)
            {
                if (msg.operType == "*POCZATEK OPERACJI*" && msg.pairId == 0)
                {
                    logmsg next_log = messages.Find(x => x.operType == "KONIEC OPERACJI" && x.operID == msg.operID && x.pairId == 0);
                    msg.pairId = pID;
                    if (next_log == null)
                    {
                        next_log = messages.Find(x => (x.operType.Contains("LOG EJ SKOPIOWANY") || x.operType.Contains("TRYB OUT OF SERVICE")) && x.ID > msg.ID);
                    }
                    next_log.pairId = pID;
                    pID++;
                }
                else if (msg.operType == "WEJSCIE W TRYB OPERATORA" && msg.pairId == 0)
                {
                    logmsg pair_log = messages.Find(x => x.operType == "WYJSCIE Z TRYBU OPERATORA" && x.ID > msg.ID);
                    msg.pairId = pID;
                    pair_log.pairId = pID;
                    pID++;
                }
                else if (msg.operType == "TRYB OUT OF SERVICE" && msg.pairId == 0)
                {
                    logmsg pair_log = messages.Find(x => x.operType == "TRYB IN SERVICE" && x.ID > msg.ID);
                    msg.pairId = pID;
                    pair_log.pairId = pID;
                    pID++;
                }
            }
            List<int> faulty = new List<int>();
            foreach (int pairs in messages.Select(x => x.pairId).Distinct())
            {
                if (messages.FindAll(x => x.pairId == pairs).Count > 2)
                    faulty.Add(pairs);
            }
            List<errorPair> errorPairs = new List<errorPair>();
            foreach (int pairs in messages.Select(x => x.pairId).Distinct())
            {
                List<logmsg> pair = messages.FindAll(x => x.pairId == pairs);
                if (pair.Find(x => x.operType == "WEJSCIE W TRYB OPERATORA") != null || pair.Find(x => x.operType == "TRYB OUT OF SERVICE") != null)
                {
                    errorPair ePair = new errorPair();
                    ePair.PairID = pairs;
                    ePair.startMsg = pair.Aggregate((i1, i2) => i1.ID < i2.ID ? i1 : i2);
                    ePair.endMsg = pair.Aggregate((i1, i2) => i1.ID > i2.ID ? i1 : i2);
                    if (ePair.startMsg.operType == "WEJSCIE W TRYB OPERATORA")
                    {
                        ePair.type = "TRYB OPERATORA";
                    }
                    else
                    {
                        ePair.type = "OUT OF SERVICE";
                    }
                    if (Convert.ToInt32((ePair.endMsg.operDate - ePair.startMsg.operDate).TotalSeconds) == 0)
                    {
                        ePair.timespan = 59;
                    }
                    else
                    {
                        ePair.timespan = Convert.ToInt32((ePair.endMsg.operDate - ePair.startMsg.operDate).TotalSeconds);
                    }
                    errorPairs.Add(ePair);
                }
                else if (pair.Find(x => x.operType.Contains("POCZATEK OPERACJI")) != null && pair.Find(x => x.operType.Contains("KONIEC OPERACJI")) == null)
                {
                    errorPair ePair = new errorPair();
                    ePair.PairID = pairs;
                    ePair.startMsg = pair.Aggregate((i1, i2) => i1.ID < i2.ID ? i1 : i2);
                    ePair.endMsg = pair.Aggregate((i1, i2) => i1.ID > i2.ID ? i1 : i2);
                    ePair.type = "OPERATION ERROR";
                    if (Convert.ToInt32((ePair.endMsg.operDate - ePair.startMsg.operDate).TotalSeconds) == 0)
                    {
                        ePair.timespan = 59;
                    }
                    else
                    {
                        ePair.timespan = Convert.ToInt32((ePair.endMsg.operDate - ePair.startMsg.operDate).TotalSeconds);
                    }
                    errorPairs.Add(ePair);
                }
            }
            foreach (errorPair ePair in errorPairs)
            {
                dg_err.Rows.Add(ePair.PairID,ePair.type, ePair.startMsg.ID, ePair.startMsg.operDate, ePair.endMsg.ID, ePair.endMsg.operDate,TimeParser(ePair.timespan));
            }
            lb_totaloper.Text = messages.Count.ToString();
            lb_totalerr.Text = errorPairs.Count.ToString();
            logmsg Tstart = messages.Aggregate((i1, i2) => i1.ID < i2.ID ? i1 : i2);
            logmsg Tend = messages.Aggregate((i1, i2) => i1.ID > i2.ID ? i1 : i2);
            int nwt = errorPairs.Sum(x => x.timespan);
            int wt = Convert.ToInt32((Tend.operDate - Tstart.operDate).TotalSeconds);
            lb_nwt.Text = TimeParser(nwt);
            lb_wt.Text = TimeParser(wt);
            lb_from.Text = Tstart.operDate.ToString();
            lb_to.Text = Tend.operDate.ToString();
            decimal progress = (Decimal.Divide((wt-nwt), wt) * 100);
            groupBox2.Text += " " + progress.ToString("F", CultureInfo.InvariantCulture) +"%";
            lb_wp.Text = progress.ToString("F", CultureInfo.InvariantCulture) + "%";
            lb_nwp.Text = (100 - progress).ToString("F", CultureInfo.InvariantCulture) + "%";
            pB1.Value = Convert.ToInt16(progress);
        }
        public string TimeParser(int sec)
        {
            string result = "";
            int hours = 0;
            int minutes = 0;
            int rest = 0;

            hours = (int)(sec / 3600);
            rest = (sec % 3600);
            minutes = (int)(rest / 60);
            rest = (rest % 60);
            result = string.Format("{0}h {1}m {2}s", hours.ToString(), minutes.ToString(), rest.ToString());

            return result;
        }
    }
}

