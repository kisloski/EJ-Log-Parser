using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_Log_Parser
{
    public partial class MainForm : Form
    {
        string[] files;
        static List<logfile> ls_files = new List<logfile>();
        public MainForm()
        {
            InitializeComponent();
            dg_files.ReadOnly = false;
            dg_files.Columns["colCheck"].ReadOnly = false;
            btn_sall.Enabled = false;
            btn_dsall.Visible = false;
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            dg_files.Rows.Clear();
            DialogResult result = fBD.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_path.Text = fBD.SelectedPath;
                files = Directory.GetFiles(fBD.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Found some files!");
                doFiles();
                btn_sall.Enabled = true;
            }
            dg_files.Refresh();
            btn_dsall.Visible = false;
            btn_sall.Visible = true;
        }
        private void doFiles()
        {
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                logfile ls_file = new logfile();
                ls_file.filename = info.Name;
                ls_file.createdate = info.CreationTime;
                ls_file.bytes = File.ReadAllBytes(file);
                ls_files.Add(ls_file);
                string str_size = "";
                if (ls_file.bytes.Length < (1024*1024))
                {
                    decimal size = decimal.Divide(ls_file.bytes.Length, 1024);
                    str_size = size.ToString("F", CultureInfo.InvariantCulture) + " KB";
                }
                else if (ls_file.bytes.Length > (1024 * 1024))
                {
                    decimal size = decimal.Divide(ls_file.bytes.Length, (1024*1024));
                    str_size = size.ToString("F", CultureInfo.InvariantCulture) + " MB";
                }
                this.dg_files.Rows.Add(null, ls_file.filename, ls_file.createdate.ToString(), str_size);
            }
        }
        private void btn_process_Click(object sender, EventArgs e)
        {
            if (dg_files.Rows.Count == 0)
            {
                MessageBox.Show("Add some files to the list!", "No files!");
            }
            else
            {
                List<logfile> ls_filestoprocess = new List<logfile>();
                foreach (DataGridViewRow row in dg_files.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        ls_filestoprocess.Add(ls_files.Find(x => x.filename == row.Cells[1].Value.ToString()));
                    }
                }
                LogView log = new LogView(ls_filestoprocess);
                log.Show();
            }
        }

        private void btn_sall_Click(object sender, EventArgs e)
        {
            if (dg_files.Rows.Count == 0)
            {
                MessageBox.Show("Add some files to the list!", "No files!");
            }
            else
            { 
                foreach (DataGridViewRow row in dg_files.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            btn_dsall.Visible = true;
            btn_sall.Visible = false;
        }

        private void btn_dsall_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_files.Rows)
            {
                row.Cells[0].Value = false;
            }
            btn_dsall.Visible = false;
            btn_sall.Visible = true;
        }
    }
}
