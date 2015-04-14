using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            TimeSpan TS = new TimeSpan(dt.Ticks);

            DateTime st = Convert.ToDateTime(TS.ToString(@"dd\.hh\:mm\:ss"));

            Console.WriteLine(st);
           // date.Add(t);
           // dt = Convert.ToDateTime(TS.ToString(@"dd\.hh\:mm\:ss"));
            //Console.WriteLine(dt);
           // Console.WriteLine("A day after the day: " + TS.ToString(@"dd\.hh\:mm\:ss"));

            String line = Console.ReadLine();

        }
    }
}
