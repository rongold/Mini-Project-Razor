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
