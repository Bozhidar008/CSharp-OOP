using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> birthdates = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {

                string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string entity = info[0];
                if (entity == "Citizen")
                {
                    string birthdate = info[4];
                    birthdates.Add(birthdate);
                    continue;
                }
                else if (entity == "Pet")
                {
                    string birthdate = info[2];
                    birthdates.Add(birthdate);
                    continue;
                }
            }
            string year = Console.ReadLine();

            foreach (var item in birthdates)
            {
                if (item.EndsWith(year))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    
}
