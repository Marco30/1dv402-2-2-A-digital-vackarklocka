using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2A
{
    class AlarmClock
    {
        // här under följer 4 (int) variabler som kommer till delas time och minut och allarm tider för time och minut 
        private int _alarmHour;
        private int _hour;
        private int _alarmMinute;
        private int _minute;

        public int AlarmHour// i den här metoden kontrolleras att _alarmHour är ett nummer mellan 0-23 och sedan till delsas den ett värde 
        {

            get { return _alarmHour; }// när man vill ha ett värde så tar man get  

            set// när man vill ge ett värde så tar man set 
            {
                if (value < 0 || value > 23)// if satsen kontrollerar om det till delade värdet är mellan 0 - 23, vilket motsvarar en tid på dygnet 
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23.");// är den inte ett värde mellan 0-23 så kastas ArgumentExceptio undantaget 
                }
                else { _alarmHour = value; }// värdet i Value ges till _alarmHour 
            }

        }



         public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59.");
                }
                else { _alarmMinute = value; }
            }

        }

        public int Hour
        {
            get { return _hour; }
            set
            {

                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                }
                else { _hour = value; }
            }

        }



        public int Minute
        {
            get { return _minute; }
            set
            {

                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59.");
                }
                else { _minute = value; }
            }

        }

       
        public AlarmClock()  //anropar konstruktorn som har  2 parametrar 
            : this(0, 0)
        {
        }

    
        public AlarmClock(int hour, int minute)  //anropar konstruktorn som har  4 parametrar 
            : this(hour, minute, 0, 0)
        {
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)// här till delas variablerna värden 
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }


        public override string ToString()
        {
            return (String.Format("{0}:{1:00} ({2}:{3:00})", Hour, Minute, AlarmHour, AlarmMinute));
        }

        public bool TickTock()
        {
           
            if (Minute == 59)
            {
                Minute = 00;

                if (Hour == 23)
                {
                    Hour = 00;
                }
                else
                {
                    Hour++;
                }
            }
            else
            {
                Minute++;
            }

            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;

            }
            return false;
        }



    }
}
