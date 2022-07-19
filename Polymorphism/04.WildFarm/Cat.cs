using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Cat : Feline
    {
        private const double feed = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
