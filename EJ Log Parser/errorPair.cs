using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_Log_Parser
{
    public class errorPair
    {
        public int PairID { get; set; }
        public logmsg startMsg { get; set; }
        public String type { get; set; }
        public logmsg endMsg { get; set; }
        public int timespan { get; set; }
    }
}
