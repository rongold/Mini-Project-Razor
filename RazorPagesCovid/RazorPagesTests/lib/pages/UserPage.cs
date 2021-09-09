using OpenQA.Selenium;
using System.Collections.Generic;

namespace RazorPagesTests.lib.pages
{
    public class UserPage
    {
        public UserPage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.UsersURL;
        private IWebElement CreateNew => Driver.FindElement(By.XPath("/html/body/div/main/p/a"));
        private IWebElement Title => Driver.FindElement(By.XPath("/html/body/div/main/h1"));
        private IWebElement DataContainer => Driver.FindElement(By.XPath("/html/body/div/main/table/tbody"));
        private IWebElement DataHeaderContainer => Driver.FindElement(By.XPath("/html/body/div/main/table/thead/tr"));
        private IList<IWebElement> DataElements => DataContainer.FindElements(By.TagName("tr"));
        private IList<IWebElement> DataHeaders => DataHeaderContainer.FindElements(By.TagName("th"));
        private IWebElement FirstEdit => DataHeaderContainer.FindElement(By.XPath("/html/body/div/main/table/tbody/tr[1]/td[8]/a[1]"));
        private IWebElement FirstDetails => DataHeaderContainer.FindElement(By.XPath("/html/body/div/main/table/tbody/tr[1]/td[8]/a[2]"));
        private IWebElement FirstAppointment => DataHeaderContainer.FindElement(By.XPath("/html/body/div/main/table/tbody/tr[1]/td[8]/a[4]"));
        public IList<IWebElement> DataLinks(int index) => DataHeaders[index].FindElements(By.TagName("a"));

        #endregion

        #region methods
        public string GetUrl() => _url;
        public string GetCurrentUrl() => Driver.Url;
        public void VisitUserPage() => Driver.Navigate().GoToUrl(_url);
        public void _date() => Driver.Navigate().GoToUrl(_url);
        public void ClickCreateNew() => CreateNew.Click();
        public string GetTitleValue() => Title.Text;


        public IWebElement GetDataByIndex(int index) => DataElements[index];
        public string GetHeaderByIndex(int index) => DataHeaders[index].Text;
        public void ClickEditByIndex(int index) => DataLinks(index)[1].Click();
        public void ClickFirstEdit() => FirstEdit.Click();
        public void ClickFirstDetails() => FirstDetails.Click();
        public void ClickFirstAppointment() => FirstAppointment.Click();
        public int GetCountOfHeaders() => DataHeaders.Count;
        public int GetCountOfUserData() => DataElements.Count;

        #endregion
    }
}

