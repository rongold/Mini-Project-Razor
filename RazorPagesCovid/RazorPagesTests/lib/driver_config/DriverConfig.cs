using OpenQA.Selenium;
using System;

namespace RazorPagesTests.lib.driver_config
{
    class DriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }

        public DriverConfig(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSecs, implicitWaitInSecs);
        }
        private void DriverSetUp(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
