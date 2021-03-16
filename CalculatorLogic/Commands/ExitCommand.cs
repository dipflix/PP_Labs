using CalculatorLogic.Commands.Base;
using System;

namespace CalculatorLogic.Commands
{
    public class ExitCommand : CommandBase
    {
        public ExitCommand() : base("Exit") { }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
