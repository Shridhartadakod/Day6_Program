using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day6 Program");
            FibonnaicSeries series = new FibonnaicSeries();
            FibonnaicSeries.Master();

            //PerfectNumber n=new PerfectNumber();
            //PerfectNumber.Member();

            PrimeNumber p=new PrimeNumber();
            PrimeNumber.Prime();

            ReverseNumber r=new ReverseNumber();
            ReverseNumber.reverse();

            StopWatch.watch();
           Console.ReadKey();
        }
    }
}
