using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender )
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public virtual string ProduceSound()
        {
            return String.Empty;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}\n{this.Name} {this.Age} {this.Gender}";
        }
    }
}
