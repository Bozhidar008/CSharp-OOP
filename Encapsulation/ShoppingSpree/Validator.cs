using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void IfStringIsNullOrEmpty(string str , string exMessage)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exMessage);
            }
        }

        public static void IfNumberIsNegative(decimal number, string exMessge)
        {
            if (number < 0)
            {
                throw new ArgumentException(exMessge);
            }
        }
    }
}
