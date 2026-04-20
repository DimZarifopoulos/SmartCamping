using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCamping
{
    public class ClimateControl
    {
        public double AcTemp { get; set; } = 22.0;
        public double HeaterTemp { get; set; } = 24.0;

        private double MinACTemp = 16.0;
        private double MaxACTemp = 26.0;

        public double MinHeaterTemp = 18.0;
        private double MaxHeaterTemp = 28.0;

        public EnergyConsumption consumption;

        // Pass consumption at constructor -> can also change the values of consumption.AirConditionOn + consumption.HeaterOn
        public ClimateControl(EnergyConsumption consumption)
        {
            this.consumption = consumption;
        }

        public void TurnOnAC()
        {
            consumption.AirConditionOn = true;      // Not simultaneously
            consumption.HeaterOn = false;
        }

        public void TurnOnHeater()
        {
            consumption.HeaterOn = true;
            consumption.AirConditionOn = false;
        }

        public void TurnOffAll()
        {
            consumption.AirConditionOn = false;
            consumption.HeaterOn = false;
        }

        public void IncreaseACTemperature()
        {
            if (AcTemp < MaxACTemp)
            {
                AcTemp += 0.5;
            }
        }

        public void DecreaseACTemperature()
        {
            if (AcTemp > MinACTemp)
            {
                AcTemp -= 0.5;
            }
        }

        public void IncreaseHeaterTemperature()
        {
            if (HeaterTemp < MaxHeaterTemp)
            {
                HeaterTemp += 0.5;
            }
        }

        public void DecreaseHeaterTemperature()
        {
            if (HeaterTemp > MinHeaterTemp)
            {
                HeaterTemp -= 0.5;
            }
        }

        // Change the temperature when on smart mode
        public void ApplySmartMode(double currentTemperature)
        {
            // AC Smart mode
            if (consumption.SmartACMode && consumption.AirConditionOn)
            {
                if (currentTemperature > 28)
                {
                    this.AcTemp = 26.0;
                }
                // else -> do nothing
            }

            // Heater Smart mode
            if (consumption.SmartHeaterMode && consumption.HeaterOn)
            {
                if (currentTemperature < 10)
                {
                    this.HeaterTemp = this.MinHeaterTemp;
                }
            }
        }
    }
}
