﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Contracts.Models
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return null;
        }
    }
}
