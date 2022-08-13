﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    internal class DesktopComputer: Computer
    {
        private const double DefaultOverallPerformance = 15;
        public DesktopComputer(int id, string manufacturer, string model, decimal price) : base(id, manufacturer, model, price, DefaultOverallPerformance)
        {

        }
    }
}