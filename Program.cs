using System.Diagnostics;
using System;

namespace EulerCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stopwatch sw = new Stopwatch();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            Console.WriteLine("Hello World!");
            
            sw.Stop();
            Console.WriteLine("Time Elapsed: {0} seconds", sw.Elapsed.TotalSeconds);
        }
    }
    interface IPuzzle
    {
        void Solve();
    }
}
