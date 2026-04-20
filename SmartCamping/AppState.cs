using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCamping
{
    // Common storage space for all shared objects
    public static class AppState
    {
        public static WeatherConditions Weather { get; } = new WeatherConditions();
        public static EnergyConsumption Consumption { get; } = new EnergyConsumption();
        public static ClimateControl Climate = new ClimateControl(AppState.Consumption);
        public static Battery Battery { get; } = new Battery();
        public static SolarPanelSystem Panels { get; } = new SolarPanelSystem();
    }
}
