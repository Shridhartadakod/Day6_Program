using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Program
{
    internal class PerfectNumber
    {
        public static void Member()
        {
            int number, sum = 0, n;
            Console.Write("enter the number: ");
            number=int.Parse(Console.ReadLine());
            n = number;
            for(int i = 0; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not perfect number");
                Console.ReadLine();

            }
        }
    }
}
