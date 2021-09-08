using OpenQA.Selenium;
using SeleniumWalkthrough.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWalkthrough.lib.pages
{
    public class SauceDemo_SigninPage
    {
        public SauceDemo_SigninPage(IWebDriver driver)
        {
            Driver = driver;
        }
        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.SignInPageUrl;
        private IWebElement _userNameField => Driver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => Driver.FindElement(By.Id("password"));
        private IWebElement _loginButton => Driver.FindElement(By.Id("login-button"));
        private IWebElement _error => Driver.FindElement(By.ClassName("error-message-container"));
        #endregion

        #region methods
        public void VistitSigninPage() => Driver.Navigate().GoToUrl(_url);
        public void InputUserName(string username) => _userNameField.SendKeys(username);
        public void InputPassword(string password) => _passwordField.SendKeys(password);
        public void ClickSignIn() => _loginButton.Click();
        public string GetErrorText() => _error.Text;

        public void InputSignInCredentals(Credentials credetials)
        {
            _userNameField.SendKeys(Credentials.Username);
            _passwordField.SendKeys(Credentials.Password);
        }
        #endregion
    }
}
