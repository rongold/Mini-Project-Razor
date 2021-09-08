using OpenQA.Selenium;
using RazorPagesTests.lib.driver_config;
using RazorPagesTests.lib.pages;

namespace RazorPagesTests.lib
{
    class Website<T> where T : IWebDriver, new()
    {
        #region
        public IWebDriver Driver { get; set; }
        public HomePage HomePage { get; set; }
        public UserPage UserPage { get; set; }
        #endregion

        public Website(int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            Driver = new DriverConfig<T>(pageLoadInSecs, implicitWaitInSecs).Driver;
            HomePage = new HomePage(Driver);
            UserPage = new UserPage(Driver);
        }

        public void DeletedCookies() => Driver.Manage().Cookies.DeleteAllCookies();
    }
}
