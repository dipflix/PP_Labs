namespace CalculatorLogic.Abstract
{
    public abstract class CalculatorAbstract
    {
        private string _memory;
        public string Memory {
            get => _memory;
            set => _memory = value;
        }
        public abstract string Calculate(string first, string second, string operation);
    }
}
