using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Clock
{
    public static class EventsArgExtension
    {
        public static void Raise<TEventArgs>(this TEventArgs e, object sender, ref EventHandler<TEventArgs> eventDelegate)
        {
            var temp = Volatile.Read(ref eventDelegate);
            if (temp != null)
                temp(sender, e);
        }
    }
}
