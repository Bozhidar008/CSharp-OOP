using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; }

        public int Food { get; }

        public void BuyFood(int Food)
        {
            Food += 5;
        }
    }
}
