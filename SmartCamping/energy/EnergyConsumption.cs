using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCamping
{
    // Class that stores the energy consuption of every device and returns the total
    public class EnergyConsumption
    {
        public double MaxConsumption { get; set; } = 2.0;   // kW
        public double BaseLoad { get; set; } = 0.3;
        public double AirConditionLoad { get; set; } = 0.5;
        public double HeaterLoad { get; set; } = 0.8;
        public double LightsLoad { get; set; } = 0.4;

        public bool AirConditionOn { get; set; } = false;
        public bool HeaterOn { get; set; } = false;
        public bool DimLights { get; set; } = false;
        public bool IsLowPowerMode { get; private set; } = false;

        // Saves the previous state before entering low power mode.
        // Initial values must be the same as the initial values of AirConditionOn and HeaterOn
        private bool prevAirCondition = false;
        private bool prevHeater = false;

        public bool SmartACMode { get; set; } = false;
        public bool SmartHeaterMode { get; set; } = false;

        public void EnableLowPowerMode()
        {
            // Save current state 
            prevAirCondition = AirConditionOn;
            prevHeater = HeaterOn;

            IsLowPowerMode = true;
            AirConditionOn = false;
            HeaterOn = false;
            DimLights = true;
        }

        public void DisableLowPowerMode()
        {
            // Bring back to previous state
            AirConditionOn = prevAirCondition;
            HeaterOn = prevHeater;

            IsLowPowerMode = false;
            DimLights = false;
        }

        public double GetTotalConsumption()
        {
            double total = BaseLoad;

            if (AirConditionOn)
            {
                // Smart Mode
                if (SmartACMode && AppState.Weather.CurrentTemperature > 28)
                {
                    total += AirConditionLoad * 0.85;   // -15%
                }
                // A/C is in standby -> do not add consumption
                else if (SmartACMode && AppState.Weather.CurrentTemperature <= 28)
                {
                }
                // Normal mode
                else
                {
                    total += AirConditionLoad;
                }
            }

            if (HeaterOn)
            {
                // Smart Mode
                if (SmartHeaterMode && AppState.Weather.CurrentTemperature < 10)
                {
                    total += HeaterLoad * 0.8;          // -20%
                }
                // Heater is in standby -> do not add consumption
                else if (SmartHeaterMode && AppState.Weather.CurrentTemperature >= 10)
                {
                }
                // Normal mode
                else
                {
                    total += HeaterLoad;
                }
            }

            if (DimLights)
            {
                total += LightsLoad / 2;                // Dim lights = half consumption;
            }
            else
            {
                total += LightsLoad;
            }

            return total;
        }

        public double GetTotalConsumptionPercent()
        {
            return (GetTotalConsumption() / MaxConsumption) * 100;
        }

        // Calculate current power saved
        public double GetCurrentPowerSaving(double currentTemperature)
        {
            double savedPower = 0.0;

            // Saving power only if -> Smart mode ON + temp > 28
            if (SmartACMode && AirConditionOn && currentTemperature > 28)
            {
                savedPower += this.AirConditionLoad * 0.15;     // saving 15% of power
            }

            // Saving power only if -> Smart mode ON + temp < 10
            if (SmartHeaterMode && HeaterOn && currentTemperature < 10)
            {
                savedPower += this.HeaterLoad * 0.20;       // saving 20% of power
            }

            return savedPower;
        }
    }
}
