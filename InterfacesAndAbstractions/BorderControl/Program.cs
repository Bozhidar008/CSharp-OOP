using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<string> ids = new List<string>();
            string input;
            while ( (input = Console.ReadLine()) != "End")
            {
                
                string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (info.Length == 3)
                {                   
                    string id = info[2];
                    ids.Add(id);                    
                    continue;
                }
                else if (info.Length == 2)
                {                    
                    string id = info[1];
                    ids.Add(id);
                    continue;
                }
            }
            string falceId = Console.ReadLine();

            foreach (var item in ids)
            {
                if (item.EndsWith(falceId))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
