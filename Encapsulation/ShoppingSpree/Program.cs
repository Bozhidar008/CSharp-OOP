using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Person> people = new Dictionary<string,Person>();
            Dictionary<string,Product> products = new Dictionary<string,Product>();
            try
            {
                people = GetPeople();
                products = GetProducts();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;                
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                var parts = input.Split();
                var personName = parts[0];
                var productName = parts[1];

                var person = people[personName];
                var product = products[productName];

                try
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }

        }

        private static Dictionary<string,Person> GetPeople()
        {
            var result = new Dictionary<string,Person>();
            var peopleInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in peopleInfo)
            {
                var parts = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var name = parts[0];
                var money = decimal.Parse(parts[1]);
                result[name] = new Person(name, money);
            }
            return result;
        }

        private static Dictionary<string,Product> GetProducts()
        {
            var result = new Dictionary<string, Product>();
            var info = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in info)
            {
                var parts = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var name = parts[0];
                var cost = decimal.Parse(parts[1]);
                result[name]= new Product(name, cost);
            }
            return result;
        }
    }
}
