using CalculatorLogic.Commands.Base;
using CalculatorLogic.Navigator;
using CalculatorLogic.Navigator.Enum;

namespace CalculatorLogic.Commands
{
    public class MoveToPageCommand : CommandBase
    {
        private PageNavigator _navigator;
        private PagesEnum _page;

        public MoveToPageCommand(PageNavigator navigator, PagesEnum page, string nameOfDo) : base(nameOfDo)
        {
            _navigator = navigator;
            _page = page;
        }

        public override void Execute() => _navigator.ChangePage(_page);
    }
}
