using CalculatorLogic.Commands;
using CalculatorLogic.Enum;
using CalculatorLogic.Navigator.Base;
using System;

namespace CalculatorLogic.Navigator
{
    public class ApplicationHomePage : NavigatorPageAbstract
    {

        public ApplicationHomePage(ConsoleCalculator calculator)
        {

            Console.WriteLine("Choose your calculator:");
            Console.WriteLine("1) Digit calculator\n2) Complex calculator\n3) Exit");

            base.AddNavigationListItem(
                new PickCalculatorCommand(calculator, CalculatorTypeEnum.DIGIT, "Digit calculator"),
                new PickCalculatorCommand(calculator, CalculatorTypeEnum.COMPLEX, "Complex calculator"),
                new ExitCommand()
                );

   
        }

        public override void Enter()
        {
            Console.Clear();
            base.RenderList();
            base.Pick(Console.ReadLine());

        }
    }
}
