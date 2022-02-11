using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Program
{
    internal class StopWatch
    {
        public int Elapsed { get; private set; }

        public static void watch()
        {
            StopWatch stopwatch = new StopWatch();
            stopwatch.Start();
            for(int i = 0;i<1000; i++)
            {
                Console.WriteLine("Bridgelabz");
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
        }

        private void Stop()
        {
            throw new NotImplementedException();
        }

        private void Start()
        {
            throw new NotImplementedException();
        }
    }
}
