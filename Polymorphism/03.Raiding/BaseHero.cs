using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding
{
    public abstract class BaseHero
    {
        
        public BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public abstract string CastAbility();
                
        public string Name { get;  }
        public int Power { get;  }
        
    }
}
