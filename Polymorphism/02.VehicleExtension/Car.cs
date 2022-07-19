using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehicleExtension
{
    public class Car : Vehicle
    {
        private const double AirConditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumtion, double tankCapacity)
            : base(fuelQuantity, fuelConsumtion, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + AirConditionConsumption;
    }
}
