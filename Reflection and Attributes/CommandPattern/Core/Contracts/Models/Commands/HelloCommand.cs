﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Contracts.Models.Commands
{
    public class HelloCommand:ICommand
    {
        
            public string Execute(string[] args)
            {
                return $"Hello, {args[0]}";
            }
        
    }
}
