using System;
using System.Collections.Generic;

namespace _04.WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Animal, double> animals = new Dictionary<Animal, double>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] anymalInfo =input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = anymalInfo[0];
                string[] foodInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);
                if (type == "Cat")
                {
                    Cat cat = new Cat(anymalInfo[1], double.Parse(anymalInfo[2]), anymalInfo[3], anymalInfo[4]);
                    Console.WriteLine(cat.MakeSound()); 
                    if (foodType == "Vegetable" || foodType == "Meat")
                    {
                        cat.Weight += 0.3 * quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                        quantity = 0;
                    }
                    animals.Add(cat,quantity);
                }
                else if (type == "Tiger")
                {
                    Tiger tiger = new Tiger(anymalInfo[1], double.Parse(anymalInfo[2]), anymalInfo[3], anymalInfo[4]);
                    Console.WriteLine(tiger.MakeSound()); 
                    if ( foodType == "Meat")
                    {
                        tiger.Weight += 1* quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                        quantity = 0;
                    }
                    animals.Add(tiger,quantity);
                }
                else if (type == "Owl")
                {
                    Owl owl = new Owl(anymalInfo[1], double.Parse(anymalInfo[2]), double.Parse(anymalInfo[3]));
                    Console.WriteLine(owl.MakeSound()); 
                    if (foodType == "Meat")
                    {
                        owl.Weight += 0.25 *quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                        quantity = 0;
                    }
                    animals.Add(owl, quantity);
                }
                else if (type == "Hen")
                {
                    Hen hen = new Hen(anymalInfo[1], double.Parse(anymalInfo[2]), double.Parse(anymalInfo[3]));
                    Console.WriteLine(hen.MakeSound()); 
                    hen.Weight += 0.35 * quantity;
                    animals.Add(hen, quantity);
                }
                else if (type == "Mouse")
                {
                    Mouse mouse = new Mouse(anymalInfo[1], double.Parse(anymalInfo[2]), anymalInfo[3]);
                    Console.WriteLine(mouse.MakeSound()); 
                    if (foodType == "Vegetable" || foodType == "Fruit")
                    {
                        mouse.Weight += 0.1 * quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                        quantity = 0;
                    }
                    animals.Add(mouse, quantity);
                }
                else if (type == "Dog")
                {
                    Dog dog = new Dog(anymalInfo[1], double.Parse(anymalInfo[2]), anymalInfo[3]);
                    Console.WriteLine(dog.MakeSound()); 
                    if (foodType == "Meat")
                    {
                        dog.Weight += 0.4 * quantity;

                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                        quantity = 0;
                    }
                    animals.Add(dog,quantity);
                }
                
            }

            foreach (var item in animals)
            {
                Console.WriteLine(item.Key.ToString() + ", " + item.Value+"]");
            }
        }
    }
}
