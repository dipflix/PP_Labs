using CalculatorLogic.Commands.Base;
using CalculatorLogic.Enum;
using CalculatorLogic.Navigator;
using CalculatorLogic.Navigator.Enum;

namespace CalculatorLogic.Commands
{
    public class PickCalculatorCommand : CommandBase
    {
        private PageNavigator pageNavigator = PageNavigator.Instance;
        private ConsoleCalculator _calculator;
        private CalculatorTypeEnum _calculatorType;
        public PickCalculatorCommand(ConsoleCalculator calculator, CalculatorTypeEnum calculatorType, string nameOfDo) : base(nameOfDo)
        {
            _calculator = calculator;
            _calculatorType = calculatorType;

        }

        public override void Execute()
        {
            _calculator.SetCalculator(CalculatorFactory.CreateCalculator(_calculatorType));

            pageNavigator.ChangePageAndCall(PagesEnum.CALCULATE);

        }
    }
}
