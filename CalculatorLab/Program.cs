using CalculatorLab.Manager;

namespace CalculatorLab
{
    public class Program
    {
       public static void Main(string[] args)
        {
            CalculatorManager _manager = CalculatorManager.Instance;
            _manager.ShowMenu();
        }

    }
}
