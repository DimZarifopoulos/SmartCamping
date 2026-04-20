using SmartCamping;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SmartCamping
{
    // Class that stores weather conditions and updates them using random library
    public partial class WeatherConditions
    {
        // Public properties
        public int CurrentTemperature { get; set; } = 15;     // °C
        public int CurrentSunlight { get; set; } = 34;       // 0–100%
        public int CurrentWindSpeed { get; set; } = 20;      // km/h
        public int CurrentHumidity { get; set; } = 60;       // 0–100%
        public string CurrentWindDirection { get; set; } = "North";

        // Private limits
        private readonly int MinTemperature = 0;
        private readonly int MaxTemperature = 40;

        private readonly int MinSunlight = 0;
        private readonly int MaxSunlight = 100;

        private readonly int MinWind = 0;
        private readonly int MaxWind = 49;

        private readonly int MinHumidity = 40;
        private readonly int MaxHumidity = 100;

        private readonly string [] WindDirections = new string[]
        {
            "North", "North-East", "East", "South-East", "South", "South-West", "West", "North-West"
        };

        public string WeatherType
        {
            get
            {
                if (CurrentSunlight < 50 && CurrentWindSpeed > 35)
                {
                    return "Stormy";
                }
                if (CurrentSunlight > 70 && CurrentWindSpeed < 20)
                {
                    return "Sunny";
                }
                if (CurrentSunlight >= 40 && CurrentSunlight <= 70)
                {
                    return "Partly Sunny";
                }
                return "Cloudy";
            }
        }

        public bool OptCanopyState ( string direction, int speed )
        {
            if ( (direction == "North" && !Cache.n_canopy) || (direction == "North-East" && (!Cache.n_canopy && !Cache.e_canopy)) ||
                (direction == "East" && !Cache.e_canopy) || (direction == "South-East" && (!Cache.s_canopy && !Cache.e_canopy)) || 
                (direction == "South" && !Cache.s_canopy) || (direction == "South-West" && (!Cache.s_canopy && !Cache.w_canopy)) ||
                (direction == "West" && !Cache.w_canopy) || (direction == "Nort-West" && (!Cache.n_canopy && !Cache.w_canopy)) || (speed >= 40))
            {
                return false;
            }
            return true;
        }

        private Random rnd = new Random();

        // Event that notifies when weather conditions change
        public event Action WeatherChanged;

        // Method for random variation near current values
        public void UpdateConditions()
        {
            // Temperature ±1
            int newTemp = CurrentTemperature + rnd.Next(-1, 2); // -1, 0, +1
            if (newTemp < MinTemperature)                       // Ensure newTemp won't exceed MinTemperature / MaxTemperature
            {
                newTemp = MinTemperature;
            }
            else if (newTemp > MaxTemperature)
            {
                newTemp = MaxTemperature;
            }
            CurrentTemperature = newTemp;

            // Wind ±1
            int newWind = CurrentWindSpeed + rnd.Next(-1, 2);
            if (newWind < MinWind)
            {
                newWind = MinWind;
            }
            else if (newWind > MaxWind)
            {
                newWind = MaxWind;
            }
            CurrentWindSpeed = newWind;

            // Humidity ±2
            int newHumidity = CurrentHumidity + rnd.Next(-2, 3);
            if (newHumidity < MinHumidity)
            {
                newHumidity = MinHumidity;
            }
            else if (newHumidity > MaxHumidity)
            {
                newHumidity = MaxHumidity;
            }
            CurrentHumidity = newHumidity;

            // Sunlight ±5
            int newSun = CurrentSunlight + rnd.Next(-5, 6);     // [-5, +5]
            if (newSun < MinSunlight)
            {
                newSun = MinSunlight;
            }
            else if (newSun > MaxSunlight)
            {
                newSun = MaxSunlight;
            }
            CurrentSunlight = newSun;

            // Trigger event to update all subscribed Forms
            WeatherChanged?.Invoke();
        }

        // Random wind direction
        public void UpdateWindDirection()
        {
            int dirIndex = rnd.Next(0, WindDirections.Length);
            CurrentWindDirection = WindDirections[dirIndex];

            // Trigger event to update all subscribed Forms
            WeatherChanged?.Invoke();
        }
    }
}
