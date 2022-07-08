using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name 
        { 
            get => name;
            set 
            {
                Validator.IfStringIsNullOrEmpty(value,"Name cannot be  empty.");
                
                this.name = value; 
            }
        }
        public decimal Cost 
        { 
            get => cost;
            set 
            {
                Validator.IfNumberIsNegative(value, "Money cannot be negative");
                
                cost = value;
            }
        }

        
    }
}
