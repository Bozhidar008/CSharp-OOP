using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class Validator
    {
        
        public static void IfNumberIsNotInRange(double minWeight, double maxWeight, double value, string exMessage)
        {
            if (value< minWeight || value > maxWeight)
            {
                throw new ArgumentException(exMessage);
            }
        }

        public static void IfValueIsNotValid(HashSet<string> validValues, string value, string exMessage)
        {
            if (!validValues.Contains(value))
            {
                throw new ArgumentException(exMessage);
            }
        }
    }
}
