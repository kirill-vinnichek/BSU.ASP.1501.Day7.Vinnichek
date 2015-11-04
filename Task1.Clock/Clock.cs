using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Clock
{ 
    public class Clock
    {
        public event EventHandler<ClockEventArgs> Alarm;

        protected virtual void OnAlarm(ClockEventArgs e)
        {
            e.Raise(this, ref Alarm);
        }

        public void Start(TimeSpan time)
        {
            Task.Run(() =>
            {
                Thread.Sleep(time);
                var e = new ClockEventArgs(DateTime.Now);
                OnAlarm(e);
            });
        }
        
    }
}
