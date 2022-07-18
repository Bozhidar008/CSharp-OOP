using System;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double fuel = double.Parse(carInfo[1]);
            double consumption = double.Parse(carInfo[2]);
            Car car = new Car(fuel, consumption);

            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double fuelT = double.Parse(truckInfo[1]);
            double consumptionT = double.Parse(truckInfo[2]);
            Truck truck = new Truck(fuelT, consumptionT);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string vehicle = input[1];
                if (command == "Drive")
                {
                    double distance = double.Parse(input[2]);
                    if (vehicle == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else if (command == "Refuel")
                {
                    double liters = double.Parse(input[2]);
                    if (vehicle == "Car")
                    {
                        car.Refuel(liters);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(liters);
                    }
                }
            }

            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:F2}");
        }
    }
}
