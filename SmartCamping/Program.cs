using Future_Camping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SmartCamping
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static Timer weatherUpdateTimer;
        private static Timer windDirectionTimer;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeWeatherTimer();
            Application.Run(new Welcome());
        }
        // Method to create the weather timer
        private static void InitializeWeatherTimer()
        {
            weatherUpdateTimer = new Timer();
            weatherUpdateTimer.Interval = 6000;
            weatherUpdateTimer.Tick += WeatherUpdateTimer_Tick;
            weatherUpdateTimer.Start();

            windDirectionTimer = new Timer();
            windDirectionTimer.Interval = 60000;
            windDirectionTimer.Tick += WindDirectionTimer_Tick;
            windDirectionTimer.Start();
        }
        // Update weather using the timer
        private static void WeatherUpdateTimer_Tick(object sender, EventArgs e)
        {
            AppState.Weather.UpdateConditions();
        }

        // Update wind direction every 60sec
        private static void WindDirectionTimer_Tick(object sender, EventArgs e)
        {
            AppState.Weather.UpdateWindDirection();
        }
    }
}
