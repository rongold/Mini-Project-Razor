using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumWalkthrough.lib;
using System.Threading;

namespace SeleniumWalkthrough.tests
{
    public class SauceDemo_Signin_Tests
    {
        private SauceDemo_Website<ChromeDriver> _website = new SauceDemo_Website<ChromeDriver>();
        private void StandaUser_Login_CorrectPassword()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.InputUserName("standard_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignIn();
        }

        #region ==============================        Sign in Page        ==============================
        [Test]
        //[Ignore("Ignore a fixture")]
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

        [Test]
        public void GivenIAmOnTheSwagLabWebsite_WhenIEnterDetails_WithLockedUsername_IGetAnErrorMessage()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.InputUserName("locked_out_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignIn();
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain("Epic sadface: Sorry, this user has been locked out."));
        }

        [Test]
        public void GivenIAmOnTheSwagLabWebsite_WhenIEnterDetails_WithProblemUsername_ShoppingPageIsShown()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.InputUserName("problem_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignIn();
            Assert.That(_website.Driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void GivenIAmOnTheSwagLabWebsite_WhenIEnterDetails_WithPerformanceUsername_ShoppingPageIsShown()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.InputUserName("performance_glitch_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignIn();
            Assert.That(_website.Driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void GivenIAmOnTheSwagLabWebsite_WhenIGoToInventoryURL_WithoutSigninIn_ErrorMessageIsGiven()
        {
            _website.HomePage.VistitSigninPage();
            Thread.Sleep(500);
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain("Epic sadface: You can only access '/inventory.html' when you are logged in."));
        }

        [Test]
        public void GivenIAmOnTheSwagLabWebsite_WhenIClickLoginButton_WithoutDetails_ErrorMessageIsGiven()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.ClickSignIn();
            Thread.Sleep(500);
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain("Epic sadface: Username is required"));
        }
        #endregion

        #region ==============================        Inventory Page        ==============================
        [Test]
        public void GivenIAmOnTheSwagLabWebsiteInvetoryPage_WhenIClickBurgerOption_ShoppingPageIsShown()
        {
            StandaUser_Login_CorrectPassword();
            _website.HomePage.BurgerButtonClick();
            Thread.Sleep(500);
            Assert.That(_website.HomePage.GetListOption, Does.Contain("ALL ITEMS"));
            Assert.That(_website.HomePage.GetListOption, Does.Contain("ABOUT"));
            Assert.That(_website.HomePage.GetListOption, Does.Contain("LOGOUT"));
            Assert.That(_website.HomePage.GetListOption, Does.Contain("RESET APP STATE"));
        }

        [Test]
        public void GivenIAmOnTheSwagLabWebsiteInvetoryPage_WhenIClickBurgerOption_And_AboutButton_AnotherPageIsShown()
        {
            StandaUser_Login_CorrectPassword();
            _website.HomePage.BurgerButtonClick();
            _website.HomePage.AboutButtonClick();
            Assert.That(_website.Driver.Url, Is.EqualTo("https://saucelabs.com/"));
        }

        [Test]
        public void GivenIAmOnTheSwagLabWebsiteInvetoryPage_WhenIClickBurgerOption_And_LogOutButton_SignInPageIsShown()
        {
            StandaUser_Login_CorrectPassword();
            _website.HomePage.BurgerButtonClick();
            _website.HomePage.LogOutButtonClick();
            Assert.That(_website.Driver.Url, Is.EqualTo("https://www.saucedemo.com/"));
        }

        [Test]
        [Ignore("")]
        public void GivenIAmOnTheSwagLabWebsiteInvetoryPage_WhenIClickTheZToASortButton_TheListIsSortedZToA()
        {
            StandaUser_Login_CorrectPassword();
            _website.HomePage.SortButtonClick();
            Thread.Sleep(50);
            _website.HomePage.ZToAClick();
            Thread.Sleep(50);
            var result = _website.HomePage.GetInventoryName();
            Assert.That(result, Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
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
