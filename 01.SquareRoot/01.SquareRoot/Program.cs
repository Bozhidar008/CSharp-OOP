using System;

namespace _01.SquareRoot
{
    public class Program
    {
        static void Main()
        {
            

            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n<0)
                {
                    throw new ArgumentException();
                }


                double num = Math.Sqrt(n);
                Console.WriteLine(num);
            }
            catch (ArgumentException )
            {

                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
