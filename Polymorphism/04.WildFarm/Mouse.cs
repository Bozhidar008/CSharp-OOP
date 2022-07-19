using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Mouse : Mammal
    {
        private const double feed = 0.1;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Squeak";
        }
    }
}
