using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string pizzaName = pizzaInfo[1];

            string[] doughInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var flourType = doughInfo[1];
            var backingTechnique = doughInfo[2];
            var weight = int.Parse(doughInfo[3]);

            
            try
            {
                var dough = new Dough(flourType, backingTechnique, weight);
                var pizza = new Pizza(pizzaName,dough);


                
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    var parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    var toppingName = parts[1];
                    var toppingWeight = double.Parse(parts[2]);

                    var topping = new Topping(toppingName,toppingWeight);
                    pizza.AddTopping(topping);
                    
                }
                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
