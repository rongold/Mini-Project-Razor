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
        //[BeforeScenario]


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

        [Then(@"The AppointmentPage url will be Correct ""(.*)"" and title will be ""(.*)""")]
        public void ThenTheAppointmentPageUrlWillBeCorrectAndTitleWillBe(string url, string title)
        {
            Assert.That(_website.AppointmentsPage.GetCurrentUrl, Is.EqualTo(url));
            Assert.That(_website.AppointmentsPage.GetTitleValue, Is.EqualTo(title));
        }

        [Given(@"I am on the AppointmentsPage")]
        public void GivenIAmOnTheAppointmentsPage()
        {
            _website.AppointmentsPage.VistitPageByURL();
        }

        [When(@"I click the CreateNew Button")]
        public void WhenIClickTheCreateNewButton()
        {
            _website.AppointmentsPage.ClickCreateNew();
        }


        [Then(@"I should view (.*)")]
        public void ThenIShouldView(string content)
        {
            Assert.That(_website.AppointmentsPage.Content(), Does.Contain(content));
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
