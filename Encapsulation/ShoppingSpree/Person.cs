using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.bag = new List<Product>();
            
        }



        public string Name 
        { 
            get => name;
            set
            {
                Validator.IfStringIsNullOrEmpty(value, "Name cannot be empty");
                this.name = value;
            }
        }
        public decimal Money 
        {
            get => money;
            set 
            {
               Validator.IfNumberIsNegative(value,"Money cannot be negative");
               
                money = value;
            }

        }

        public void AddProduct(Product product)
        {                                  
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
            bag.Add(product);
            this.Money -= product.Cost;
        }

        public override string ToString()
        {
            if (this.bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            return $"{this.Name} - {string.Join(", ", this.bag.Select(p=>p.Name))}";
        }
    }
}
