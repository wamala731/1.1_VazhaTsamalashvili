using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_4
{
    internal class Clock
    {
        private int Hours { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }
        public Clock()
        {
            Hours = 12;
            Minutes = 0;
            Seconds = 0;
        }
        public Clock(int hours, int minutes, int seconds, out string errorMessage)
        {
            if (hours < 0 || hours > 23)
            {
                errorMessage = "Invalid hours value.";
                Hours = 0;
            }
            else if (minutes < 0 || minutes > 59)
            {
                errorMessage = "Invalid minutes value.";
                Minutes = 0;
            }
            else if (seconds < 0 || seconds > 59)
            {
                errorMessage = "Invalid seconds value.";
                Seconds = 0;
            }else
            {
                errorMessage = "";
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

  
        }

        public int getHours()
        {
            return Hours;
        }
        public int getMinutes()
        {
            return Minutes;
        }
        public int getSeconds()
        {
            return Seconds;
        }

        public void setTime(DateTime time)
        {
            Hours = time.Hour;
            Minutes = time.Minute;
            Seconds = time.Second;
        }
        public void showTime()
        {
            if (Hours < 10)
            {
                Console.Write("0");
            }
            Console.Write(Hours + ":");
            if (Minutes < 10)
            {
                Console.Write("0");
            }
            Console.Write(Minutes + ":");
            if (Seconds < 10)
            {
                Console.Write("0");
            }
            Console.WriteLine(Seconds);
        }

        public void tickDown()
        {
            if (Seconds == 0)
            {
                Seconds = 59;
                if (Minutes == 0)
                {
                    Minutes = 59;
                    if (Hours == 0)
                    {
                        Hours = 23;
                    }
                    else
                    {
                        Hours--;
                    }
                }
                else
                {
                    Minutes--;
                }
            }
            else
            {
                Seconds--;
            }
        }

        public void addHours(int hour)
        {
            if (Hours + hour >= 24)
            {
                Hours = (Hours + hour) % 24;


            }
            else
            {
                Hours += hour;
            }
        }

    }
}