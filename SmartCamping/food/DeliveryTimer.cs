using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCamping
{
    public static class DeliveryTimer
    {
        public static int SecondsLeft { get; private set; } = -1;
        private static Timer timer = new Timer() { Interval = 1000 };

        public static event Action TimerFinished;

        static DeliveryTimer()
        {
            timer.Tick += (s, e) =>
            {
                if (SecondsLeft > 0)
                {
                    SecondsLeft--;
                }
                else if (SecondsLeft == 0)
                {
                    timer.Stop();
                    TimerFinished?.Invoke(); // notify all listeners
                    SecondsLeft = -1;        // prevent retrigger
                }
            };
        }

        public static void Start(int seconds)
        {
            SecondsLeft = seconds;
            timer.Start();
        }

        public static void Stop()
        {
            timer.Stop();
            SecondsLeft = -1;
        }
    }
}

