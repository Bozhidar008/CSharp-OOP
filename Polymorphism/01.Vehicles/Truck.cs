using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private double fuel;
        private double consumption;
        public Truck(double fuel, double consumption)
        {
            this.Fuel = fuel;
            this.Consumption = consumption;
        }

        public double Fuel 
        {
            get
            {
                return this.fuel;
            }
            set
            {
                this.fuel = value;
            }
        }
        public double Consumption 
        {
            get 
            {
                return this.consumption + 1.6;
            }
            set
            { 
                this.consumption = value;
            } 
        }

        public void Drive(double distance)
        {
            if ((this.Fuel - distance * Consumption) >= 0)
            {
                this.Fuel -= Consumption * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
             this.Fuel += liters * 0.95;            
        }
    }
}
