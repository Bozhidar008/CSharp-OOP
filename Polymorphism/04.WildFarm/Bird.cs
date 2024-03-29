﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight ,double wingSize):base(name, weight)
        {
            this.WingSize = wingSize;
        }

        private double WingSize { get; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}";
        }
    }
}
