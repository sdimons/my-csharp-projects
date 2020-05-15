using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopwatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("Duration 0: {0}", stopwatch.Duration);
            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine("Duration 1: {0}", stopwatch.Duration);
            stopwatch.Start();
            Thread.Sleep(2000);
            stopwatch.Start();
            stopwatch.Stop();
        }
    }
}
