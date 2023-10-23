using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_OOP_dolgozat_KorteA
{
    internal class Timer
    {
    public int RemainingSeconds {  get; set; }

    public Timer(int remainingSeconds) 
        { 
        
            RemainingSeconds = remainingSeconds;
        }

    public void SetTime(int second) 
        { 
            RemainingSeconds = second; 
        }

    public void StartTimer()
        {
            for (int i = 0; i < RemainingSeconds; i++) 
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"A hátralévő idő {i}");
            }
        }


    }
}
