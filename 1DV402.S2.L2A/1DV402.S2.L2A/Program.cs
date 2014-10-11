using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2A
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();
            int minutes;

            string HorizontalLine = "\n-------------------";
            Console.WriteLine(HorizontalLine);

            Console.WriteLine("1 test");
            Console.WriteLine("Test av stadardkonstruktorn.");
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine("");
          
            Console.WriteLine("2 test");
            Console.WriteLine("Test av konstruktorn med två parametrar.");
            alarmClock.Hour = 9;
            alarmClock.Minute = 42;
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine("");
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            int i = 0;
            while (i < minutes)
            {
                ac.TickTock();
                i++;
                Console.WriteLine(ac.ToString());
            }
        }

        private static void ViewErrorMessage(string message)
        {
       
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(header);
            Console.ResetColor();

        }

    }
}
