using System;
using System.Collections.Generic;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> citizens = new List<string>();
            List<string> rebels = new List<string>();
            int n = int.Parse(Console.ReadLine());
            int Food = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (info.Length == 4)
                {
                    citizens.Add(info[0]);
                }
                else if (info.Length == 3)
                {
                    rebels.Add(info[0]);
                }
                
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string name =command.Trim();
                if (citizens.Contains(name))
                {
                    Food += 10;
                }
                else if (rebels.Contains(name))
                {
                    Food += 5;
                }
            }

            Console.WriteLine(Food);
        }
    }
}
