using CalculatorLogic.Navigator.Base;
using System;


namespace CalculatorLogic.Navigator
{
    public class CalculatePage : NavigatorPageAbstract
    {
        private Lazy<ConsoleCalculator> _calculator = new Lazy<ConsoleCalculator>(() => new ConsoleCalculator());
        public ConsoleCalculator Calculator
        {
            get => _calculator.Value;
        }

        public override void Enter()
        {
            if (_calculator is null) throw new Exception($"[{this.GetType().Name.ToUpper()}] calculator is null");
            _calculator.Value.ShowCalculator();
        }
    }
}
