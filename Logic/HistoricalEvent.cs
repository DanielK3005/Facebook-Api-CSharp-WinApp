using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class HistoricalEvent
    {
        public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

        public string EventDescription { get; set; }

        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}:", this.Day, this.Month, this.Year);
        }
    }
}
