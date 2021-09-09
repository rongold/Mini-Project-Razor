using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RazorPagesTests.lib;
using System;
using TechTalk.SpecFlow;

namespace RazorPagesCovidTests.BDD
{
    [Binding]
    public class UserTestSceneriosSteps
    {
        Website<ChromeDriver> _website = new Website<ChromeDriver>();
        private int userQuantity = 3;
        [Given(@"I am on the Userpage")]
        public void GivenIAmOnTheUserpage()
        {
            _website.UserPage.VisitUserPage();
        }


        [When(@"I Click CreateUser")]
        public void WhenIClickCreateUser()
        {
            _website.UserPage.ClickCreateNew();
        }

        [When(@"I click Edit")]
        public void WhenIClickEdit()
        {
            _website.UserPage.ClickFirstEdit();
        }

        [When(@"I click Details")]
        public void WhenIClickDetails()
        {
            _website.UserPage.ClickFirstDetails();
        }

        [When(@"I click Appointment")]
        public void WhenIClickAppointment()
        {
            _website.UserPage.ClickFirstAppointment();
        }


        [Then(@"The page url will be Correct ""(.*)"" and title will be users ""(.*)""")]
        public void ThenThePageUrlWillBeCorrectAndTitleWillBeUsers(string url, string title)
        {
            Assert.That(_website.UserPage.GetCurrentUrl, Is.EqualTo(url));
            Assert.That(_website.UserPage.GetTitleValue, Is.EqualTo(title));
        }

        [Then(@"I will see the correct amount of users")]
        public void ThenIWillSeeTheCorrectAmountOfUsers()
        {
            Assert.That(_website.UserPage.GetCountOfUserData, Is.EqualTo(userQuantity));
        }

        [Then(@"It will display Correct Amount Of User Headers")]
        public void ThenItWillDisplayCorrectAmountOfUserHeaders()
        {
            Assert.That(_website.UserPage.GetCountOfHeaders, Is.EqualTo(8));
        }

        [Then(@"It will display the correct user headers")]
        public void ThenItWillDisplayTheCorrectUserHeaders()
        {
            Assert.That(_website.UserPage.GetHeaderByIndex(0), Is.EqualTo("First Name"));
            Assert.That(_website.UserPage.GetHeaderByIndex(1), Is.EqualTo("Last Name"));
            Assert.That(_website.UserPage.GetHeaderByIndex(2), Is.EqualTo("Age"));
            Assert.That(_website.UserPage.GetHeaderByIndex(3), Is.EqualTo("House Number"));
            Assert.That(_website.UserPage.GetHeaderByIndex(4), Is.EqualTo("Street Name"));
            Assert.That(_website.UserPage.GetHeaderByIndex(5), Is.EqualTo("Postcode"));
            Assert.That(_website.UserPage.GetHeaderByIndex(6), Is.EqualTo("Phone Number"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _website.Driver.Quit();
            _website.Driver.Dispose();
        }


    }
}
