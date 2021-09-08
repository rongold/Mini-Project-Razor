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

        #endregion

        #region methods
        public string GetUrl() => _url;

        #endregion
    }
}
