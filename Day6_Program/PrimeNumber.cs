using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Program
{
    internal class PrimeNumber
    {
        public static void Prime()
        {
            Console.Write(" enter the number:");
            int number=int.Parse(Console.ReadLine());
            bool Is_Prime = true;
            for(int i = 2; i < number / 2; i++)
            {
                if(number % i == 0)
                {
                    Is_Prime = false;
                    break;
                }
            }
            if (Is_Prime)
            {
                Console.Write("number is Prime number");
            }
            else
            {
                Console.Write("number is not prime number");
            }
            Console.ReadKey();
        }

    }
}
