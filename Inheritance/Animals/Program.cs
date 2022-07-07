using System;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string type = Console.ReadLine();
                if (type == "Beast!")
                {                    
                    break;
                }
                string[] info = Console.ReadLine().Split(' ');
                string name = info[0];
                int age = int.Parse(info[1]);
                string gender = info[2];
                if (string.IsNullOrEmpty(name)|| string.IsNullOrEmpty(gender)|| age < 0)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
               
                
                if (type == "Cat")
                {
                    Cat cat = new Cat(name, age,  gender );
                    Console.WriteLine(cat);
                    string sound = cat.ProduceSound();
                    Console.WriteLine(sound);
                }
                else if (type == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog);
                    string sound = dog.ProduceSound();
                    Console.WriteLine(sound);
                }
                else if (type == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(frog);
                    string sound = frog.ProduceSound();
                    Console.WriteLine(sound);
                }
                else if (type == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    Console.WriteLine(kitten);
                    string sound = kitten.ProduceSound();
                    
                }
                else if (type == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    Console.WriteLine(tomcat);
                    string sound = tomcat.ProduceSound();
                    Console.WriteLine(sound);
                }                
            }
        }
    }
}
