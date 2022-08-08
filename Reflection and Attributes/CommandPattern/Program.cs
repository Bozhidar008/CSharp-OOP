
namespace CommandPattern
{
    using CommandPattern.Core.Contracts;
    using CommandPattern.Core.Contracts.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}
