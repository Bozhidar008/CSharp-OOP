﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public class Motherboard : Component
    {
        private const double Multiplier = 1.25;

        protected Motherboard(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance * Multiplier, generation)
        {

        }
    }
}
