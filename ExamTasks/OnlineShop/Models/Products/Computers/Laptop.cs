using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    internal class Laptop : Computer
    {
        private const double DefaultOverallPerformance = 10;
        public Laptop(int id, string manufacturer, string model, decimal price) : base(id, manufacturer, model, price, DefaultOverallPerformance)
        {

        }
    }
}
