using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.EnterNumbers
{
    public class Program
    {
        

        static void Main()
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);

            static void ReadNumber(int start, int end)
            {
                
                int prevNum = 0;
                        List<int> numbers = new List<int>();
                while (numbers.Count<10)
                {
                    
                    try
                    {
                        int num = int.Parse(Console.ReadLine());
                        if (num <= start || num >= end)
                        {
                            Console.WriteLine($"Your number is not in range {num} - 100!");
                            continue;
                        }                        
                        if (prevNum >= num)
                        {
                            
                        }
                        else
                        {
                            prevNum = num;

                            numbers.Add(num);
                        }
                        
                    }                    
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid Number!");
                    }
                    
                }

                Console.Write(String.Join(", ", numbers));

            }



        }

        
    }
}
