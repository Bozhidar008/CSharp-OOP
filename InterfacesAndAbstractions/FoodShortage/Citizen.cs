using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        private string name;
        private int age;
        private string id;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;            
            this.Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; }

        public int Food { get; }

        public void BuyFood(int Food)
        {
            Food += 10;
        }
    }
}
