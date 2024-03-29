﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    internal class SolidStateDrive:Component
    {
        private const double Multiplier = 1.20;

        protected SolidStateDrive(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance * Multiplier, generation)
        {

        }
    }
}
