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
        private IWebElement InputField => DataHeaderContainer.FindElement(By.XPath("/html/body/div/main/form/p/input[1]"));
        private IWebElement StreetNameDropDownMenu => DataHeaderContainer.FindElement(By.XPath("/html/body/div/main/form/p/select"));
        private IList<IWebElement> StreetNameDropDownMenuFields => StreetNameDropDownMenu.FindElements(By.TagName("option"));
        private IWebElement FilterButton => DataHeaderContainer.FindElement(By.XPath("/html/body/div/main/form/p/input[2]"));
        private IWebElement CreateButton => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[8]/input"));
        private IList<IWebElement> DataLinks(int index) => DataHeaders[index].FindElements(By.TagName("a"));

        #endregion

        #region methods
        public string GetUrl() => _url;
        public string GetCurrentUrl() => Driver.Url;
        public void VisitUserPage() => Driver.Navigate().GoToUrl(_url);
        public void ClickCreateNew() => CreateNew.Click();
        public string GetTitleValue() => Title.Text;


        public IWebElement GetDataByIndex(int index) => DataElements[index];
        public string GetHeaderByIndex(int index) => DataHeaders[index].Text;
        //public void ClickEditByIndex(int index) => DataHeaders(index)[1].Click();
        public void ClickFirstEdit() => FirstEdit.Click();
        public void ClickCreateButton() => CreateButton.Click();
        public void ClickFilterButton() => FilterButton.Click();
        public void ClickFirstDetails() => FirstDetails.Click();
        public void ClickFirstAppointment() => FirstAppointment.Click();
        public void EnterIntoInputField(string input) => InputField.SendKeys(input);
        public void SelectStreetNameMenuFieldFromIndex(int index) => StreetNameDropDownMenuFields[index].Click();
        public int GetCountOfHeaders() => DataHeaders.Count;
        public int GetCountOfUserData() => DataElements.Count;


        #endregion

        #region errors

        public string GetErrorTextByIndex(int index) => Driver.FindElement(By.XPath($"/html/body/div/main/div[1]/div/form/div[{index}]/span/span")).Text;
        public string FirstNameError => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[1]/span/span")).Text;
        public string LastNameError => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[2]/span/span")).Text;
        public string AgeError => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[3]/span/span")).Text;
        public string HouseNumbeError => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[4]/span/span")).Text;
        public string StreetNumberError => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[5]/span/span")).Text;
        public string PostcodeError => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[6]/span/span")).Text;
        public string PhoneNumberErrorError => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[7]/span/span")).Text;
        #endregion
    }
}
