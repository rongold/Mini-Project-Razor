using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumWalkthrough.lib;
using System.Threading;

namespace SeleniumWalkthrough.tests
{
    public class SauceDemo_Signin_Tests
    {
        private SauceDemo_Website<ChromeDriver> _website = new SauceDemo_Website<ChromeDriver>();

        #region ==============================        Sign in Page        ==============================
        [Test]
        [Ignore("Ignore a fixture")]
        public void GivenIAmOnTheSwagLabWebsite_WhenIEnterTheWongPassword_IGetAnErrorMessage()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.InputUserName("standard_user");
            _website.SignInPage.InputPassword("sauce");
            _website.SignInPage.ClickSignIn();
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]
        public void GivenIAmOnTheSwagLabWebsite_WhenIEnterCorrectDetails_ShoppingPageIsShown()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.InputUserName("standard_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignIn();
            Assert.That(_website.Driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        #endregion

        [OneTimeTearDown]
        public void CleanUp()
        {
            _website.Driver.Quit();
            _website.Driver.Dispose();
        }
    }
}
