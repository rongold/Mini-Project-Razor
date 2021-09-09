using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RazorPagesTests.lib;
using System;
using TechTalk.SpecFlow;


namespace RazorPagesTests.BDD
{
    [Binding]
    public class HomePageSteps
    {
        private Website<ChromeDriver> _website = new Website<ChromeDriver>();

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _website.HomePage.GoToHomePage();
        }

        [When(@"I click the homepage button")]
        public void WhenIClickTheHomepageButton()
        {
            _website.HomePage.ClickHomePageButton();
        }

        [Then(@"I should stay on the homepage")]
        public void ThenIShouldStayOnTheHomepage()
        {
            Assert.That(_website.Driver.Url, Is.EqualTo("https://localhost:44328/"));
        }

        [When(@"I click the razorpage button")]
        public void WhenIClickTheRazorpageButton()
        {
            _website.HomePage.ClickRazorPagesCovidButton();
        }

        [When(@"I click the vaccine link")]
        public void WhenIClickTheVaccineLink()
        {
            _website.HomePage.ClickOurVaccineButton();
        }
        
        [Then(@"I go to the vaccinepage")]
        public void ThenIGoToTheVaccinepage()
        {
            Assert.That(_website.Driver.Url, Is.EqualTo("https://localhost:44328/Covid/Vaccines"));
        }

        [When(@"I click the Users Button")]
        public void WhenIClickTheUsersButton()
        {
            _website.HomePage.ClickUsersButton();
        }

        [Then(@"I go to the Users page")]
        public void ThenIGotToTheUsersPage()
        {
            Assert.That(_website.Driver.Url, Is.EqualTo("https://localhost:44328/Covid/Users"));
        }

        [When(@"I click the appointments button")]
        public void WhenIClickTheAppointmentsButton()
        {
            _website.HomePage.ClickAppointmentButton();
        }

        [Then(@"I go to the appointments page")]
        public void ThenIGoToTheAppointmentsPage()
        {
            Assert.That(_website.Driver.Url, Is.EqualTo("https://localhost:44328/Covid/Appointments"));
        }
        [When(@"I click the privacy button")]
        public void WhenIClickThePrivacyButton()
        {
            _website.HomePage.ClickPrivacyButton();
        }

        [Then(@"I go to the privacy page")]
        public void ThenIGoToThePrivacyPage()
        {
            Assert.That(_website.Driver.Url, Is.EqualTo("https://localhost:44328/Privacy"));
        }


        [AfterScenario]
        public void QuitWebDriver()
        {
            _website.Driver.Quit();

        }
        [OneTimeTearDown]
        public void DisposeWebDriver()
        {
            _website.Driver.Dispose();

        }

    }
}
