using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_Log_Parser
{
    public class logmsg
    {
        public int ID { get; set; }
        public string operID { get; set; }
        public string operType { get; set; }
        public DateTime operDate { get; set; }
        public string loglifename { get; set; }
        public int pairId { get; set; }
    }
}
