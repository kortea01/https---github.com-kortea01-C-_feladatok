using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_OOP_dolgozat_KorteA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock(12, 30, 45, "UTC+2", true);

            List<Alarm> alarmList = new List<Alarm>();
            Alarm alarm1 = new Alarm(6, 0);
            Alarm alarm2 = new Alarm(8, 0);
            alarmList.Add(alarm1);
            alarmList.Add(alarm2);

            Timer idozito = new Timer(10);

            myClock.DisplayTime();

            foreach (Alarm alarm in alarmList)
            {
                //todo: megszerezni az aktuális órát, percet
                if (alarm.IsAlarmTime(12, 20)) {
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
                
            }
            idozito.StartTimer();

        }

    
        
   

    }
    
}
