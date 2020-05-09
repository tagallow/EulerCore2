using System.Linq;
using System.Diagnostics;
using System;

namespace EulerCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // Mult3And5.Solve();
            HighlyDivisibleTriangularNumber.Solve();

            sw.Stop();
            Console.WriteLine("Time Elapsed: {0:n0} minutes {1:n0} seconds {2:n0} milliseconds", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);

            // sw.Restart();
            // sw.Stop();
            // Console.WriteLine("Time Elapsed: {0:n0} minutes {1:n0} seconds {2:n0} milliseconds", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);
        }
    }
}