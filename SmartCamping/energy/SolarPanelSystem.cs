using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCamping
{
    // Class that calculates solar panel's production and efficiency
    public class SolarPanelSystem
    {
        public double MaxProduction { get; private set; } = 2.5; // kW
        public double CurrentProduction { get; private set; } = 0.0;
        public double Efficiency { get; private set; } = 100.0; // %

        // Association with weather
        public void UpdatePerformance(WeatherConditions weather)
        {
            // Calculation based on current sunlight
            Efficiency = weather.CurrentSunlight;

            // Production calculation (kW)
            CurrentProduction = (Efficiency / 100.0) * MaxProduction;
        }
    }
}
