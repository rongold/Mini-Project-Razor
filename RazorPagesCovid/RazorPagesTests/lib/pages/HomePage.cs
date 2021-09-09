using OpenQA.Selenium;

namespace RazorPagesTests.lib.pages
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
        private IWebElement _usersButton => this.Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a"));
        private IWebElement _appointmentsButton => this.Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
        private IWebElement _privacyButton => this.Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[5]/a"));
        private IWebElement _homeButton => this.Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[1]/a"));
        private IWebElement _razorPagesCovidButton => this.Driver.FindElement(By.XPath("/html/body/header/nav/div/a"));
        #endregion

        #region methods
        public string GetUrl() => _url;
        public void GoToHomePage() => Driver.Navigate().GoToUrl(_url);
        public string GetCurrentUrl() => Driver.Url;
        public void ClickRazorPagesCovidButton() => _razorPagesCovidButton.Click();
        public void ClickHomePageButton() => _homeButton.Click();
        public void ClickOurVaccineButton() => _vaccineButton.Click();
        public void ClickUsersButton() => _usersButton.Click();
        public void ClickAppointmentButton() => _appointmentsButton.Click();
        public void ClickPrivacyButton() => _privacyButton.Click();
        #endregion
    }
}
