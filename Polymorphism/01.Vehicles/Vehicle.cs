using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public interface Vehicle
    {
        public double Fuel { get; set; }
        public double Consumption { get; set; }
        
        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);

    }
}
