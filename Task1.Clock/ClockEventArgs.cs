using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Clock
{
    public class ClockEventArgs:EventArgs
    {
        public DateTime DateTime { get; set; }

        public ClockEventArgs(DateTime dateTime)
        {
            this.DateTime = dateTime;
        }
    }
}
