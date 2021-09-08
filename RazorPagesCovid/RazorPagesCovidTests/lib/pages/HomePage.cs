using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesCovidTests.lib.pages
{
    class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.HomePageUrl;
        private IWebElement _vaccineButton => this.Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a"));
        #endregion

        #region methods
        public string GetUrl() => _url;
        public void GoToHomePage() => Driver.Navigate().GoToUrl(_url);
        public string GetCurrentUrl() => Driver.Url;
        public void ClickOurVaccineButton() => _vaccineButton.Click();
        
        #endregion
    }
}
