using OpenQA.Selenium;
using RazorPagesCovidTests.lib.driver_config;
using RazorPagesCovidTests.lib.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesCovidTests.lib
{
    class Website<T> where T: IWebDriver, new()
    {
        #region
        public IWebDriver Driver { get; set; }
        public HomePage HomePage { get; set; }
        #endregion

        public Website(int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            Driver = new DriverConfig<T>(pageLoadInSecs, implicitWaitInSecs).Driver;
            HomePage = new HomePage(Driver);
        }

        public void DeletedCookies() => Driver.Manage().Cookies.DeleteAllCookies();
    }
}
