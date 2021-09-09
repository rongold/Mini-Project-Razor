using OpenQA.Selenium;

namespace RazorPagesTests.lib.pages
{
    class AppointmentsCreatePage
    {
        public AppointmentsCreatePage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.AppointmentsCreateURL;
        //private IWebElement _appointementsButton => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[1]/input"));

        #endregion

        #region methods
        public string GetUrl() => _url;
        public void VistitPageByURL() => Driver.Navigate().GoToUrl(_url);
        //public void VistitPageByNavBar() => _appointementsButton.Click();
        #endregion
    }
}
