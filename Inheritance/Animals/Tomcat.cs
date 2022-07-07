﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    internal class Tomcat: Cat
    {
        private const string DefaultGender = "Male";
        public Tomcat(string name, int age) : base(name, age, DefaultGender)
        {

        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}