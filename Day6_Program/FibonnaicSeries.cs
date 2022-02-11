using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Program
{
   public class FibonnaicSeries
    {
        
        public static int fib (int n)
        {
            if (n <= 1)
            {
                return n;

            }
            else
            {
                return fib (n - 1) + fib(n-2);
            }
        }
        public static void Master()
        {
            int n = 8;
            Console.WriteLine(fib(n));
            Console.ReadKey();

        }
    }
}
