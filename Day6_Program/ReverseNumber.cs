using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Program
{
    internal class ReverseNumber
    {
        public static void reverse()
        {
            Console.WriteLine("Enter the number to br reverse:");
            int number=int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                Reverse = (Reverse * 10) + remainder;
                number /= 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
