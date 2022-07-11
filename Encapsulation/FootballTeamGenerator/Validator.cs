using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void IsStatInRange(int minLength, int maxLength, int value, string exMessage)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentException(exMessage);
            }
        }
        public static void IsNameValid(string value, string exMessage)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(exMessage);
            }
        }
    }
}
