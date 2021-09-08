using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RazorPagesCovidTests.lib;
using System;
using TechTalk.SpecFlow;

namespace RazorPagesCovidTests.BDD
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
            Assert.That(_website.Driver.Url,Is.EqualTo("https://localhost:44328/Covid/Vaccines"));
        }
    }
}
