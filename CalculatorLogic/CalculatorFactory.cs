using CalculatorLogic.Enum;
using CalculatorLogic.Abstract;
using CalculatorLogic.Logic;
using System;

namespace CalculatorLogic
{
    public class CalculatorFactory
    {
        public static CalculatorAbstract CreateCalculator(CalculatorTypeEnum typeCalculator)
        {
            switch (typeCalculator)
            {
                case CalculatorTypeEnum.DIGIT:
                    return new DigitCalculator();
                case CalculatorTypeEnum.COMPLEX:
                    return new ComplexCalculator();
                default:
                    throw new Exception("Calculator type is not found!");
            }
        }
    }
}
