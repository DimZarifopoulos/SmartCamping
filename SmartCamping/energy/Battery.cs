using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCamping
{
    public class Battery
    {
        public double Capacity { get; private set; } = 5.0; // kWh
        public double Level { get; private set; } = 2.5;    // kWh

        public double Charge(double energy)
        {
            // Ensure (Level + energy) won't exceed Capacity
            Level = Level + energy;
            if (Level > Capacity)
            {
                Level = Capacity;
            }
            return Level;
        }

        public double Discharge(double energy)
        {
            // Ensure (Level - energy) won't exceed 0
            Level = Level - energy;
            if (Level < 0)
            {
                Level = 0;
            }
            return Level;
        }

        public double GetChargePercent()
        {
            return (Level / Capacity) * 100;
        }
    }
}
