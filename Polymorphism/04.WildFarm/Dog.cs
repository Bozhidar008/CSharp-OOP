using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Dog : Mammal
    {
        private const double feed = 0.4;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
