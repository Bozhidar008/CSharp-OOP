using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    internal class Pizza
    {
        private const int maxNameLength = 15;
        private const int minNameLength = 1;
        private const int maxNumberOfToppings = 10;
              
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name 
        { 
            get => name;
            private set 
            {
                if (value.Length < minNameLength || value.Length > maxNameLength)
                {
                    throw new ArgumentException($"Pizza name should be between {minNameLength} and {maxNameLength} symbols.");
                }
                this.name = value;
            }
        }

        public void AddTopping(Topping topping)
        {                        
            if ( this.toppings.Count == maxNumberOfToppings)
            {
                throw new InvalidOperationException($"Number of toppings should be in range [0..{maxNumberOfToppings}].");
            }            
                this.toppings.Add(topping);
                      
        }

        

        public double GetTotalCalories()
        {
            return this.dough.GetCalories() + this.toppings.Sum(p => p.GetCalories());
        }
    }
}
