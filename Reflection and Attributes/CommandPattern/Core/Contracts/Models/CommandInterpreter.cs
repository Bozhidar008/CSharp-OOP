using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core.Contracts.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string _commandSufix = "Command";
        public string Read(string args)
        {
            string[] tokens = args.Split();
            string commandName = tokens[0];
            string[] commandArrgs = tokens[1..];

            Type commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == $"{commandName}{_commandSufix}");
            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command type");
            }
            ICommand command = (ICommand)Activator.CreateInstance(commandType);
            string result = command.Execute(commandArrgs);
            return result;
        }
    }
}
