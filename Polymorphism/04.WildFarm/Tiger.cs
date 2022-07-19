using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Tiger : Feline
    {
        private const double feed = 1;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string MakeSound()
        {
            return "ROAR!!!";
        }
    }
}
