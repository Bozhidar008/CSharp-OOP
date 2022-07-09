using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int minWeight = 1;
        private const int maxWeight = 50;

        
        private string name;
        private double weight;

        public Topping(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name 
        { 
            get => this.name;
            private set 
            {
                Validator.IfValueIsNotValid(new HashSet<string> { "meat", "veggies", "cheese", "sauce" }, value.ToLower(), $"Cannot place {value} on top of your pizza.");

                this.name = value;
            }
        }
        public double Weight 
        { 
            get => weight;
            private set 
            {
                Validator.IfNumberIsNotInRange(minWeight, maxWeight, value, $"{this.Name} weight should be in the range [{minWeight}..{maxWeight}].");

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var toppingModifier = GetToppingTypeModifier();
            return this.Weight * 2 * toppingModifier;
        }

        private double GetToppingTypeModifier()
        {
            var toppingTypeModifier = this.Name.ToLower();

            if (toppingTypeModifier == "meat")
            {
                return 1.2;
            }
            if (toppingTypeModifier == "veggies")
            {
                return 0.8;
            }
            if (toppingTypeModifier == "cheese")
            {
                return 1.1;
            }
            return 0.9;
        }
    }
}
