using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    internal class RandomAccessMemory: Component
    {
        private const double Multiplier = 1.20;

        protected RandomAccessMemory(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance * Multiplier, generation)
        {

        }
    }
}
