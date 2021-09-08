using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RazorPagesCovidTests.lib;
using System;
using TechTalk.SpecFlow;

namespace RazorPagesCovidTests.BDD
{
    [Binding]
    public class UserTestSceneriosSteps
    {
        Website<ChromeDriver> _website = new Website<ChromeDriver>();
        [Given(@"I am on the Userpage")]
        public void GivenIAmOnTheUserpage()
        {
            _website.UserPage.VisitUserPage();
        }

        [Then(@"The page url will be Correct ""(.*)"" and title will be users ""(.*)""")]
        public void ThenThePageUrlWillBeCorrectAndTitleWillBeUsers(string url, string title)
        {
            Assert.That(_website.UserPage.GetCurrentUrl, Is.EqualTo(url));
        }
    }
}
