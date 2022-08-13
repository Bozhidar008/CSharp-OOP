using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public class CentralprocessingUnit : Component
    {
        private const double Multiplier = 1.25;

        protected CentralprocessingUnit(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance * Multiplier, generation)
        {
            
        }

        
    }
}
