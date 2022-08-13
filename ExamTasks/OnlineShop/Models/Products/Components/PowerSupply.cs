using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    internal class PowerSupply: Component
    {
        private const double Multiplier = 1.05;

        protected PowerSupply(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance * Multiplier, generation)
        {

        }
    }
}
