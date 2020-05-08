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

            var p = Tools.GetPrimes();

            sw.Stop();
            Console.WriteLine("sieve2 done, {0} items", p.Count);
            Console.WriteLine("Time Elapsed: {0:n0} minutes {1:n0} seconds {2:n0} milliseconds",
                sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);

        }
    }
}