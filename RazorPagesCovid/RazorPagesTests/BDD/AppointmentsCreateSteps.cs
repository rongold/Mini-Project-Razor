using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RazorPagesTests.lib;
using System;
using TechTalk.SpecFlow;

namespace RazorPagesTests.BDD
{
    [Binding]
    public class AppointmentsCreateSteps
    {
        private Website<ChromeDriver> _website = new Website<ChromeDriver>();

        [Given(@"I am on the Appointment Create Page")]
        public void GivenIAmOnTheAppointmentCreatePage()
        {
            _website.AppointmentsCreatePage.VistitPageByURL();
        }
        
        [Then(@"I should see (.*)")]
        public void ThenIShouldSee(string content)
        {
            Assert.That(_website.AppointmentsCreatePage.Content, Does.Contain(content));
        }

        [When(@"I click the Create Button")]
        public void WhenIClickTheCreateButton()
        {
            _website.AppointmentsCreatePage.ClickCreateButton();
        }

        [Then(@"I should observe the following error under location: ""(.*)""")]
        public void ThenIShouldObserveTheFollowingErrorUnderLocation(string error)
        {
            Assert.That(_website.AppointmentsCreatePage.LocationErrorMessage, Is.EqualTo(error));
        }

        [Then(@"I should observe the following error under date: ""(.*)""")]
        public void ThenIShouldObserveTheFollowingErrorUnderDate(string error)
        {
            Assert.That(_website.AppointmentsCreatePage.DateErrorMessage, Is.EqualTo(error));
        }

        [Given(@"I click on the DateBar and select an invalid date (.*)")]
        public void GivenIClickOnTheDateBarAndSelectAnInvalidDate(string date)
        {
            _website.AppointmentsCreatePage.DateBarInput(date);
        }

        [Given(@"I click on the LocationBar and type an invalid location: (.*)")]
        public void GivenIClickOnTheLocationBarAndTypeAnInvalidLocation(string location)
        {
            _website.AppointmentsCreatePage.LocationBarInput(location);
        }

        [When(@"I click the Back To List Button")]
        public void WhenIClickTheBackToListButton()
        {
            _website.AppointmentsCreatePage.ClickBackButton();
        }

        [Then(@"I should be redirected back to the AppointmentPage with url: ""(.*)"" and title ""(.*)""")]
        public void ThenIShouldBeRedirectedBackToTheAppointmentPageWithUrlAndTitle(string url, string title)
        {
            Assert.That(_website.AppointmentsCreatePage.GetCurrentUrl, Is.EqualTo(url));
            Assert.That(_website.AppointmentsCreatePage.GetTitleValue, Is.EqualTo(title));
        }

        [Then(@"I should be redirected back to the AppointmentPage with url: ""(.*)""")]
        public void ThenIShouldBeRedirectedBackToTheAppointmentPageWithUrl(string url)
        {
            Assert.That(_website.AppointmentsCreatePage.GetCurrentUrl, Is.EqualTo(url));
        }

        [Given(@"I type a valid location")]
        public void GivenITypeAValidLocation()
        {
            _website.AppointmentsCreatePage.LocationBarInput("London");
        }

        [Given(@"I select a valid date")]
        public void GivenISelectAValidDate()
        {
            _website.AppointmentsCreatePage.DateBarInput("21-11-2021");
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
