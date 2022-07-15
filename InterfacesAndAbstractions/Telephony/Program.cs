using System;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] webSites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in numbers)
            {
                
                if (!item.Any(i=>char.IsLetter(i)) && item.Length == 7)
                {
                    Console.WriteLine($"Dialing... {item}");
                }
                else if (!item.Any(i=>char.IsLetter(i)) && item.Length == 10)
                {
                    Console.WriteLine($"Calling... {item}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var item in webSites)
            {
                if (item.Any(i=>char.IsDigit(i)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else 
                {
                    Console.WriteLine($"Browsing: {item}!");
                }
            }
        }
    }
}
