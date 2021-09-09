using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RazorPagesTests.lib;
using System;
using TechTalk.SpecFlow;

namespace RazorPagesTests.BDD
{
    [Binding]
    public class AppointmentsSteps
    {
        private Website<ChromeDriver> _website = new Website<ChromeDriver>();

        [Given(@"I am on the Homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _website.AppointmentsPage.HomePage();
        }

        [When(@"I click the Appointments Button")]
        public void WhenIClickTheAppointmentsButton()
        {
            _website.AppointmentsPage.AppointmentstPageByNavBar();
        }

        [Then(@"The AppointmentPage url will be Correct ""(.*)"" and title will be users ""(.*)""")]
        public void ThenTheAppointmentPageUrlWillBeCorrectAndTitleWillBeUsers(string url, string title)
        {
            Assert.That(_website.AppointmentsPage.GetCurrentUrl, Is.EqualTo(url));
            Assert.That(_website.AppointmentsPage.GetTitleValue, Is.EqualTo(title));
        }

        [Given(@"I am on the AppointmentPage")]
        public void GivenIAmOnTheAppointmentPage()
        {
            _website.AppointmentsPage.VistitPageByURL();
        }

        [When(@"I click the CreateNew Button")]
        public void WhenIClickTheCreateNewButton()
        {
            _website.AppointmentsPage.ClickCreateNew();
        }



        [AfterScenario]
        public void DisposeWebDriver()
        {
            _website.Driver.Quit();
            _website.Driver.Dispose();
        }
    }
}
