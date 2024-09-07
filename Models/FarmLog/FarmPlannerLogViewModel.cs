using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerAPICore.Models.FarmLog
{
    public class FarmPlannerLogViewModel
    {
        public int id { get; set; }
        public string uid { get; set; }
        public DateTime datalog { get; set; }
        public string transacao { get; set; }

        public string? username { get; set; } = null;
        public string idconta { get; set; }
    }
}