using CalculatorLogic.CommandPattern;

namespace CalculatorLogic.Commands.Base
{
    public abstract class CommandBase : ICommand
    {
        private string _nameOfDo = "";
        public string NameOfDo { get => _nameOfDo; private set => _nameOfDo = value; }

        public CommandBase(string nameOfDo) => NameOfDo = nameOfDo;

        public abstract void Execute();
    }
}
