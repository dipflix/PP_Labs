using CalculatorLogic;
using CalculatorLogic.Navigator;
using CalculatorLogic.Navigator.Enum;
using System;

namespace CalculatorLab.Manager
{
    public class CalculatorManager
    {
        private static readonly Lazy<CalculatorManager> _instance = new Lazy<CalculatorManager>(()=> new CalculatorManager());

        public static CalculatorManager Instance
        {
            get =>  _instance.Value;
        }


        private PageNavigator pageNavigator;
        private ApplicationHomePage homePage;

        private CalculatePage calculatePage;



        public CalculatorManager() {
            calculatePage = new CalculatePage();

            pageNavigator = PageNavigator.Instance;

            homePage = new ApplicationHomePage(calculatePage.Calculator);

            pageNavigator.AddPage(PagesEnum.HOME, homePage);
            pageNavigator.AddPage(PagesEnum.CALCULATE, calculatePage);

            pageNavigator.ChangePage(PagesEnum.HOME);
        }

        public void ShowMenu()
        {
            try
            {
                pageNavigator.Call();
            }
            catch (Exception)
            {
                Console.Clear();
                ShowMenu();
            }
        }

    }
}
