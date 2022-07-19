using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> heroes = new List<BaseHero>();

            while(heroes.Count != n)
            {                
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                if (type == "Paladin")
                {                    
                    heroes.Add(new Paladin(name));
                }
                else if (type == "Druid")
                {                    
                    heroes.Add(new Druid(name));
                }
                else if (type == "Rogue")
                {                    
                    heroes.Add(new Rogue(name));
                }
                else if (type == "Warrior")
                {                    
                    heroes.Add(new Warrior(name));
                }
                else 
                {
                    Console.WriteLine("Invalid hero!");
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility()); 
                
            }
            int heroesPower = heroes.Sum(h => h.Power);
            if (bossPower <= heroesPower)
            {
                Console.WriteLine("Victory!");
            }
            else 
            { 
                Console.WriteLine("Defeat..."); 
            }

        }
    }
}
