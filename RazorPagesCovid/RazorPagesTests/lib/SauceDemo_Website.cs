using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWalkthrough.lib.pages;
using SeleniumWalkthrough.lib.driver_config;

namespace SeleniumWalkthrough.lib
{
    public class SauceDemo_Website<T> where T : IWebDriver, new()
    {
        #region PageObjects and Driver Properties
        public IWebDriver Driver { get; set; }
        public SauceDemo_HomePage HomePage { get; set; }
        public SauceDemo_SigninPage SignInPage { get; set; }
        #endregion

        public SauceDemo_Website(int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            Driver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitWaitInSecs).Driver;
            HomePage = new SauceDemo_HomePage(Driver);
            SignInPage = new SauceDemo_SigninPage(Driver);
        }
        public void DeleteCookies() => Driver.Manage().Cookies.DeleteAllCookies();
    }
}
