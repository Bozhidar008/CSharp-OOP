﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;            
        }

        public string Name { get; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract string MakeSound();

        private const double feed = 0;
        public  double Feed()
        {
            return this.Weight + feed;
        }

    }
}
