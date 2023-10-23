using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clock_OOP_dolgozat_KorteA
{
    internal class Clock
    {
        public int Hour {  get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string TimeZone { get; set; }
        public bool Is24HourFormat { get; set; }

       public Clock(int hour,  int minute, int second, string timeZone, bool is24HourFormat)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            TimeZone = timeZone;
            Is24HourFormat = is24HourFormat;
        }

        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            
        }

        public void DisplayTime()
        {
            Console.WriteLine($"A pontos idő: {Hour}:{Minute}:{Second}, az időzóna {TimeZone} ");
        }

        public void SetTimeZone(string timeZone)
        {
            TimeZone = timeZone;
        }

        public void ToggleTimeFormat()
        {
            if (Is24HourFormat) {
                Is24HourFormat = false;
                           
            }else
            {
                Is24HourFormat = true;
            }
        } 

    }
}
