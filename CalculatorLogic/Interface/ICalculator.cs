using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLogic.Interface
{
	public interface ICalculator<TArgument, in TOperation> where TArgument: struct

	{
		TArgument MemoryNumber { get; set; }
		TArgument Plus(TArgument first, TArgument second);
		TArgument Minus(TArgument first, TArgument second);
		TArgument Multiply(TArgument first, TArgument second);
		TArgument Divide(TArgument first, TArgument second);
		TArgument Calculate(TArgument first, TArgument second, TOperation operation);
	}

}
