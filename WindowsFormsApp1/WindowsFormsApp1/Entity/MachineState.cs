using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class MachineState
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public int State { get; set; }
        public DateTime Date { get; set; }
        public long Downtime { get; set; }
        public bool FlagDown { get; set; }

        public int Counter { get; set; }
    }
}
