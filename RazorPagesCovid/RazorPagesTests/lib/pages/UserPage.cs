using OpenQA.Selenium;

namespace RazorPagesTests.lib.pages
{
    public class UserPage
    {
        public UserPage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.UsersURL;

        #endregion

        #region methods
        public string GetUrl() => _url;
        public string GetCurrentUrl() => Driver.Url;
        public void VisitUserPage() => Driver.Navigate().GoToUrl(_url);

        #endregion
    }
}

