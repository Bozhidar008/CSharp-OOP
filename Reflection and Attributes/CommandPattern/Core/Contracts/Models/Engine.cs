﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Contracts.Models
{
    public class Engine:IEngine
    {
        private  ICommandInterpreter _commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this._commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                string result = this._commandInterpreter.Read(command);
                if (result == null)
                {
                    break;
                }
                Console.WriteLine(result);
            }
        }
    }
}
