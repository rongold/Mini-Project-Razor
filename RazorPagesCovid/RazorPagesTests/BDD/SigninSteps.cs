using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SeleniumWalkthrough.lib;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SeleniumWalkthrough.utilities;
using System.Threading;

namespace SeleniumWalkthrough.BDD
{
    [Binding]
    public class SigninSteps
    {
        private SauceDemo_Website<ChromeDriver> _website = new SauceDemo_Website<ChromeDriver>();

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            _website.SignInPage.VistitSigninPage();
        }

        [Given(@"I have entered the username ""(.*)""")]
        public void GivenIHaveEnteredTheUsername(string username)
        {
            _website.SignInPage.InputUserName(username);
        }

        [Given(@"I have entered the password ""(.*)""")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            _website.SignInPage.InputPassword(password);
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            _website.SignInPage.ClickSignIn();
        }

        [Then(@"I should see an error message ""(.*)""")]
        public void ThenIShouldSeeAnErrorMessage(string message)
        {
            Thread.Sleep(500);
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain(message));
        }

        [Given(@"I have the following credentials:")]
        public void GivenIHaveTheFollowingCredentials(Table table)
        {
            var credentials = table.CreateInstance<Credentials>();
            _website.SignInPage.InputSignInCredentals(credentials);
        }


        //================================================================= Unnessesary
        // the following statement should be recognised by SpecFlow
        #region
        [Given(@"I have entered the usernames (.*)")]
        public void GivenIHaveEnteredTheUsernames(string username)
        {
            _website.SignInPage.InputUserName(username);
        }

        [Given(@"I have entered the passwords (.*)")]
        public void GivenIHaveEnteredThePasswords(string password)
        {
            _website.SignInPage.InputPassword(password);
        }

        [Then(@"I should see an error messages (.*)")]
        public void ThenIShouldSeeAnErrorMessages(string message)
        {
            Thread.Sleep(500);
            Assert.That(_website.SignInPage.GetErrorText(), Does.Contain(message));
        }
        #endregion

        [Then(@"I should be directed to the following website ""(.*)""")]
        public void ThenIShouldBeDirectedToTheFollowingWebsite(string url)
        {
            Thread.Sleep(500);
            Assert.That(_website.Driver.Url, Is.EqualTo(url));
        }

        [When(@"I tryto access the Invetory page")]
        public void WhenITrytoAccessTheInvetoryPage()
        {
            _website.HomePage.VistitSigninPage();
        }


        [Given(@"I have successfully logged in")]
        public void GivenIHaveSuccessfullyLoggedIn()
        {
            _website.SignInPage.VistitSigninPage();
            _website.SignInPage.InputUserName("standard_user");
            _website.SignInPage.InputPassword("secret_sauce");
            _website.SignInPage.ClickSignIn();
        }

        [When(@"I click on the burger button")]
        public void WhenIClickOnTheBurgerButton()
        {
            _website.HomePage.BurgerButtonClick();
        }

        [Then(@"I should view (.*)")]
        public void ThenIShouldView(string content)
        {
            Thread.Sleep(500);
            Assert.That(_website.HomePage.GetListOption, Does.Contain(content));
        }

        [When(@"I click on the ABOUT button")]
        public void WhenIClickOnTheABOUTButton()
        {
            _website.HomePage.AboutButtonClick();
        }

        [When(@"I click on the LOGOUT button")]
        public void WhenIClickOnTheLOGOUTButton()
        {
            _website.HomePage.LogOutButtonClick();
        }




        [AfterScenario]
        public void DisposeWebDriver()
        {
            _website.Driver.Quit();
            _website.Driver.Dispose();
        }
    }
}
