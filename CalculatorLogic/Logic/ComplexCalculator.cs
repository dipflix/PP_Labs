using CalculatorLogic.Interface;
using CalculatorLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CalculatorLogic.Logic
{
	public class ComplexCalculator : CalculatorAbstract, IOperand<Complex>
	{

		public ComplexCalculator()
		{
			base.Memory = "0,0 0,0";
		}
		public Complex Plus(Complex first, Complex second)
		{
			return first + second;
		}
		public Complex Minus(Complex first, Complex second)
		{
			return first - second;
		}
		public Complex Multiply(Complex first, Complex second)
		{
			return first * second;
		}
		public Complex Divide(Complex first, Complex second)
		{
			if (second == 0)
				throw new DivideByZeroException();
			return first.Real / second.Real;
		}

		public Complex Calculate(Complex first, Complex second, string operation)
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

		public override string Calculate(string first, string second, string operation)
		{

            Complex firstArg;
            Complex secondArg;
            var firstSplit = first.Split(' ');
            var secondSplit = second.Split(' ');
            string realFirst = string.Empty;
            string realSecond = string.Empty;
            string imFirst = string.Empty;
            string imSecond = string.Empty;

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in firstSplit[i])
                {
                    if (char.IsNumber(item) || item.Equals(','))
                    {
                        if (i == 0)
                            realFirst += item;
                        else
                            imFirst += item;
                    }
                }
                foreach (var item in secondSplit[i])
                {
                    if (char.IsNumber(item) || item.Equals(','))
                    {
                        if (i == 0)
                            realSecond += item;
                        else
                            imSecond += item;
                    }
                }

            }
            firstArg = new Complex(Convert.ToDouble(realFirst), Convert.ToDouble(imFirst));
            secondArg = new Complex(Convert.ToDouble(realSecond), Convert.ToDouble(imSecond));
		

			Complex temp = Calculate(firstArg, secondArg, operation);

            return string.Format($"{temp.Real} {temp.Imaginary}");
        }


	}
}
