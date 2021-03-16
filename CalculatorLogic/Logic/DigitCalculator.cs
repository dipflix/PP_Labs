using CalculatorLogic.Abstract;
using CalculatorLogic.Interface;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CalculatorLogic.Logic
{
	public class DigitCalculator: CalculatorAbstract, IOperand<double>
	{
		public DigitCalculator() {
			base.Memory = "0";
		}
		public double Plus(double first, double second) => first + second;

		public double Minus(double first, double second) => first - second;

        public double Multiply(double first, double second) => first* second;

		public double Divide(double first, double second)
        {
			if (second == 0)
				throw new DivideByZeroException();
			return first / second;
		}
		public override string Calculate(string first, string second, string operation)
		{
			double firstArg = Convert.ToDouble(first);
			double secondArg = Convert.ToDouble(second);

			return Calculate(firstArg, secondArg, operation).ToString();
		}
		public double Calculate(double first, double second, string operation)
        {
			switch (operation)
			{
				case "+":
					return Plus(first, second);
				case "-":
					return Minus(first, second);
				case "*":
					return Multiply(first, second);
				case "/":
					return Divide(first, second);
				default:
					throw new Exception("No such operation!");
			}
		}

   
	}

}
