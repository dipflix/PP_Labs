using System;
using CalculatorLogic.Abstract;
using CalculatorLogic.Interface;
using CalculatorLogic.Navigator;
using CalculatorLogic.Navigator.Enum;

namespace CalculatorLogic
{
    public class ConsoleCalculator : IRenderCalculator
    {

        private CalculatorAbstract _someCalculator = null;

        public void SetCalculator(CalculatorAbstract someCalculator) => _someCalculator = someCalculator;

        public bool IsCalculateInit() => _someCalculator != null;
        public void ShowCalculator()
        {
            Console.Clear();
            Console.WriteLine($"Calculator: {_someCalculator.GetType().Name}\nEnter 'back' for back to home\n");
            Console.WriteLine(_someCalculator.Memory);
            string operation = Console.ReadLine();
            if (operation.Equals("back"))
                //Environment.Exit(0);
                PageNavigator.Instance.ChangePageAndCall(PagesEnum.HOME);


            while (true)
            {
                try
                {
              
                    string number = Console.ReadLine();
                    _someCalculator.Memory = _someCalculator.Calculate(_someCalculator.Memory, number, operation);
                    Console.Clear();
                    ShowCalculator();

                }
                catch (Exception exception)
                {
                    Console.Clear();
                    Console.WriteLine(exception.Message+ "\nPress any key for back");
                    Console.ReadLine();
                    ShowCalculator();
                }
            }

        }
    }
}
