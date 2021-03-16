using CalculatorLogic.Commands.Base;
using System;
using System.Collections.Generic;

namespace CalculatorLogic.Navigator.Base
{
    // Можно ещё улучшить, если не забуду
    public abstract class NavigatorPageAbstract
    {
        private PageNavigator pageNavigator = null;
        private List<CommandBase> _listItems;

        public PageNavigator PageNavigator { get => pageNavigator; internal set => pageNavigator = value; }

        protected NavigatorPageAbstract()
        {
            _listItems = new List<CommandBase>();
        }

        internal void SetPageNavigator(PageNavigator pageNavigator) => this.PageNavigator = pageNavigator;


        public void AddNavigationListItem(params CommandBase[] items)
        {
            foreach (CommandBase item in items)
                _listItems.Add(item);
        }

        public void RenderList()
        {
            for (var i = 0; i < _listItems.Count; i++)
                Console.WriteLine($"{i}) {_listItems[i].NameOfDo}");
        }

        public abstract void Enter();

        public void Pick(int index) {
            if (_listItems[index] is null) throw new Exception("[NavigatorPageAbstract] index outside");

            _listItems[index].Execute();
        }

        internal void Pick(string v)
        {
           this.Pick(int.Parse(v));
        }
    }
}
