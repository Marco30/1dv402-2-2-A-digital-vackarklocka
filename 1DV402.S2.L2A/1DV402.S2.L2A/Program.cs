using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2A// Marco villegas
{
    class Program
    {
        static void Main(string[] args)// här testar vi klockan och des funktioner    
        {
            AlarmClock alarmClock = new AlarmClock();

            int minutes;

            string HorizontalLine = "\n-------------------";

            Console.WriteLine(HorizontalLine);
            ViewTestHeader("test 1:\nTest av stadardkonstruktorn\n");

            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine();

            Console.WriteLine(HorizontalLine);
            ViewTestHeader("test 2: \nTest av konstruktorn med 2 parametrar\n");

            alarmClock.Hour = 9;
            alarmClock.Minute = 42;

            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine();

            Console.WriteLine(HorizontalLine);
            ViewTestHeader("test 3: \nTest av konstruktorn med 4 parametrar\n");

            alarmClock.Hour = 9;
            alarmClock.Minute = 42;
            alarmClock.AlarmHour = 7;
            alarmClock.AlarmMinute = 35;

            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine();

            Console.WriteLine(HorizontalLine);
            Console.WriteLine("test 4: \nStäller befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter\n");

            alarmClock.Hour = 23;
            alarmClock.Minute = 58;
            alarmClock.AlarmHour = 7;
            alarmClock.AlarmMinute = 35;
            minutes = 13;
            Run(alarmClock, minutes);
            Console.WriteLine();

            Console.WriteLine(HorizontalLine);
            Console.WriteLine("test 5: \nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter\n");

            alarmClock.Hour = 6;
            alarmClock.Minute = 12;
            alarmClock.AlarmHour = 6;
            alarmClock.AlarmMinute = 15;
            minutes = 6;
            Run(alarmClock, minutes);
            Console.WriteLine();

            Console.WriteLine("Test 6: \nTestar egenskaperna så att undantag kastas då tid - min och alarmtid - alarmmin tilldelas felaktiga värden.\n");

            try
            {
                alarmClock.Hour = 34;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmClock.Minute = 61;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmClock.AlarmHour = 3000;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmClock.AlarmMinute = 700;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            Console.WriteLine("Test 7: \nTestar egenskaperna så att undantag kastas då tid - min och alarmtid - alarmmin tilldelas felaktiga värden.\n");
            
            try
            {
                alarmClock.AlarmHour = 3000;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }


            try
            {
                alarmClock.AlarmMinute = 700;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
       
        }

        private static void Run(AlarmClock ac, int minutes)// metoden starart klockan och bestämmer hur många minuter den ska köras 
        {
            int i = 0;
            while (i < minutes)
            {
                ac.TickTock();
                i++;
                Console.WriteLine(ac.ToString());
            }
        }

        private static void ViewErrorMessage(string message)//presenterar fel meddelande och  ändrar färgen på texten till  vit och bakgrunden till röd 
        {
       
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)// visar text 
        {
            Console.WriteLine(header);

        }

    }
}
