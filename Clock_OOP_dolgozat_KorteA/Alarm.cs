using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_OOP_dolgozat_KorteA
{
    internal class Alarm
    {
        public int alarmHour {  get; set; }
        public int alarmMinute { get; set; }

        

        public bool isAlarmOn {  get; set; }

        public Alarm(int alarmHour, int alarmMinute)
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
            isAlarmOn = true;
        }

        public void SetAlarm(int hour, int minute) 
        {
            alarmHour = hour; 
            alarmMinute = minute;
        } 

        public void TurnOnAlarm()
        {
            isAlarmOn = true;
        }

        public void TurnOffAlarm() 
        { 
           isAlarmOn = false;
        }

        public bool IsAlarmTime(int hour, int minute)
        {
            if (hour == alarmHour && minute == alarmMinute) 
            {
            
                return true;
            } else 
            { 
                return false; 
            }


        }

    }
}
