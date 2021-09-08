using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWalkthrough.lib.pages
{
    public class SauceDemo_HomePage
    {
        public SauceDemo_HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.InventoryPageUrl;
        private IWebElement _burgerButton => Driver.FindElement(By.Id("react-burger-menu-btn"));
        private IWebElement _allItems => Driver.FindElement(By.Id("inventory_sidebar_link"));
        private IWebElement _about => Driver.FindElement(By.Id("about_sidebar_link"));
        private IWebElement _logout => Driver.FindElement(By.Id("logout_sidebar_link"));
        private IWebElement _resetAppState => Driver.FindElement(By.Id("reset_sidebar_link"));
        private IWebElement _sortButton => Driver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement _zToA => Driver.FindElement(By.XPath("xpath=//div[@id='header_container']/div[2]/div[2]/span/select"));
        private IWebElement _inventoryName => (IWebElement)Driver.FindElements(By.Id("inventory_item_name"));
        #endregion

        #region methods
        public void VistitSigninPage() => Driver.Navigate().GoToUrl(_url);
        public void BurgerButtonClick() => _burgerButton.Click();
        public void AllItemsButtonClick() => _allItems.Click();
        public void AboutButtonClick() => _about.Click();
        public void LogOutButtonClick() => _logout.Click();
        public void SortButtonClick() => _sortButton.Click();
        public void ZToAClick() => _zToA.Click();

        public List<string> GetListOption()
        {
            var list = new List<string>()
            {
                _allItems.Text,
                _about.Text,
                _logout.Text,
                _resetAppState.Text
            };

            return list;
        }
        public List<string> GetInventoryName()
        {
            var list = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                list.Add(_inventoryName.Text);
            }

            return list;
        }

        #endregion
    }
}
