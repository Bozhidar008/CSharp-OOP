using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int minWeight = 1;
        private const int maxWeight = 200;

        private const string DoughExceptionMessage = "Invalid type of dough.";

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType 
        { 
            get => flourType;
            set 
            {
                if (value.ToLower() != "white"&& value.ToLower() !="wholegrain")
                {
                    throw new ArgumentException(DoughExceptionMessage);
                }

                this.flourType = value;
            }
        }
        public string BakingTechnique 
        { 
            get => bakingTechnique;
            set 
            {
                if (value.ToLower() != "crispy"&& value.ToLower() !="chewy"&& value.ToLower() !="homemade")
                {
                    throw new ArgumentException(DoughExceptionMessage);
                }
                this.bakingTechnique = value;
            }
        }
        public double Weight 
        { 
            get => weight;
            private set 
            {
                Validator.IfNumberIsNotInRange(minWeight, maxWeight, value, $"Dough weight should be in range [{minWeight}..{maxWeight}].");
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var flourTypeModifier = GetFlourTypeModifier();
            var bakingTechniqueModifier = GetBakingTechniqueModifier();

            return this.Weight * 2 * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetBakingTechniqueModifier()
        {
            var backingTechnique = this.BakingTechnique.ToLower();
            if (backingTechnique == "crispy")
            {
                return 0.9;
            }
            if (backingTechnique == "chewy")
            {
                return 1.1;
            }
            return 1;
        }

        private double GetFlourTypeModifier()
        {
            var flourType =this.FlourType.ToLower();
            if (flourType == "white")
            {
                return 1.5;
            }
            return 1;
        }
    }
}
