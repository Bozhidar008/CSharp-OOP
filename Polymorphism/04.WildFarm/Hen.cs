using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Hen : Bird
    {
        private const double feed = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        
        public override string MakeSound()
        {
            return "Cluck";
        }
        
    }
}
