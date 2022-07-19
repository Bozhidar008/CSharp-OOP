using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    internal class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        private const double feed = 0.25;
        public override string MakeSound()
        {
            return "Hoot Hoot";
        }
    }
}
