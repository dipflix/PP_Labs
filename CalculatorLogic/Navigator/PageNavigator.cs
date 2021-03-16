using CalculatorLogic.Navigator.Base;
using CalculatorLogic.Navigator.Enum;
using System;
using System.Collections.Generic;

namespace CalculatorLogic.Navigator
{
    public class PageNavigator
    {
        private static readonly Lazy<PageNavigator> _instance = new Lazy<PageNavigator>(() => new PageNavigator());
        public static PageNavigator Instance
        {
            get => _instance.Value;

        }

        private Dictionary<PagesEnum, NavigatorPageAbstract> _pagesCache;
        private NavigatorPageAbstract _currentPage = null;
        

        public PageNavigator()
        {
            _pagesCache = new Dictionary<PagesEnum, NavigatorPageAbstract>();

        }
        public void AddPage(PagesEnum page, NavigatorPageAbstract pageObject)
        {
            pageObject.SetPageNavigator(this);
            _pagesCache.Add(page, pageObject);
        }

        public void ChangePage(PagesEnum page) => setCurrentPage(page);

        public void ChangePageAndCall(PagesEnum page)
        {
            ChangePage(page);
            Call();
        }


        private void setCurrentPage(PagesEnum page)
        {
            _currentPage = _pagesCache[page];
        }


        public void Call()
        {
            if (_currentPage is null) throw new Exception($"[{this.GetType().Name.ToUpper()}] current page is null");

            _currentPage.Enter();
        }


    }
}
