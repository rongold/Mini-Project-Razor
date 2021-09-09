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

        [When(@"I click the appointments link")]
        public void WhenIClickTheAppointmentsLink()
        {
            _website.AppointmentsPage.AppointmentstPageByNavBar();
        }
        
        [Then(@"I go to the appointmentspage")]
        public void ThenIGoToTheAppointmentspage()
        {
            Assert.That(_website.Driver.Url, Is.EqualTo("https://localhost:44328/Covid/Appointments"));
        }
    }
}
