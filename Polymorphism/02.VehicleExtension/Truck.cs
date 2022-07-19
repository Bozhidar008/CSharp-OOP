using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehicleExtension
{
    public class Truck : Vehicle
    {
        private const double AirConditionConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumtion, double tankCapacity)
            : base(fuelQuantity, fuelConsumtion, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + AirConditionConsumption;

        public override void Refuel(double amount)
        {
            if (base.FuelQuantity + amount > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }
            base.Refuel(amount * 0.95);
        }
    }
}
