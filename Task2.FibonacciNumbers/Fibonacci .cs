using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.FibonacciNumbers
{
    public static class  Fibonacci 
    {
        public static IEnumerable<int> GetFibonacciNumbers(int amount)        
        {
            int a = 0;
            int b = 1;
            int i = 0;
            while (i<amount)
            {
                yield return a;
                i++;
                int next = b;
                b += a;
                a = next;
            }
        }
    }
}
