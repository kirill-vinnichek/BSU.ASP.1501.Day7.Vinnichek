using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Clock;
using Task2.FibonacciNumbers;
namespace Task1.UI
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
        public void Register (Task1.Clock.Clock clock)
        {
            clock.Alarm += Do;
        }

        public void Unregister(Task1.Clock.Clock clock)
        {
            clock.Alarm -= Do;
        }

        private void Do(object sender,ClockEventArgs e)
        {
            Console.WriteLine(Name + " " + e.DateTime.ToShortTimeString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Bob");
            var p2 = new Person("Jimmi");
            var clock = new Task1.Clock.Clock();
            p1.Register(clock);
            p2.Register(clock);
            clock.Start(TimeSpan.FromSeconds(2));
            
            foreach (var e in Fibonacci.GetFibonacciNumbers(10))
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
