using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefaktorisaniSims.Model
{
    class AdvancedRenovation
    {
        public string id { get; set; }
        public string room1_id { get; set; }
        public string room2_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime finish_time { get; set; }
    }
}
