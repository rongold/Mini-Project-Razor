using OpenQA.Selenium;
using System.Collections.Generic;

namespace RazorPagesTests.lib.pages
{
    class AppointmentsCreatePage
    {
        public AppointmentsCreatePage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url_App = AppConfigReader.AppointmentsURL;
        private string _url_Create = AppConfigReader.AppointmentsCreateURL;

        private IWebElement Title => Driver.FindElement(By.XPath("/html/body/div/main/h1"));
        private IWebElement SubTitle => Driver.FindElement(By.XPath("/html/body/div/main/h4"));
        private IWebElement Location => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[1]/label"));
        private IWebElement DateOfAppointment => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[2]/label"));
        private IWebElement VaccineName => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[3]/label"));
        private IWebElement FullName => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[4]/label"));
        private IWebElement LocationBar => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[1]/input"));
        private IWebElement LocationError => Driver.FindElement(By.Id("Apppointment_Location-error"));
        private IWebElement DateBar => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[2]/input"));
        private IWebElement DateError => Driver.FindElement(By.Id("Apppointment_DateOfAppointment-error"));
        private IWebElement VaccineDropDown => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[3]/select"));
        private IWebElement NameDropDown => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[4]/select"));
        private IWebElement CreateButton => Driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[5]/input"));
        private IWebElement BackButton => Driver.FindElement(By.XPath("/html/body/div/main/div[2]/a"));

        #endregion

        #region methods
        public List<string> Content()
        {
            var list = new List<string>
            {
                Title.Text,
                SubTitle.Text,
                Location.Text,
                DateOfAppointment.Text,
                VaccineName.Text,
                FullName.Text,
            };

            return list;
        }
        public string GetUrl() => _url_Create;
        public void VistitPageByURL() => Driver.Navigate().GoToUrl(_url_Create);
        public string GetCurrentUrl() => Driver.Url;
        public string GetTitleValue() => Title.Text;
        public string GetSubTitleValue() => SubTitle.Text;

        public void ClickCreateButton() => CreateButton.Click();
        public void ClickBackButton() => BackButton.Click();

        public void LocationBarInput(string location) => LocationBar.SendKeys(location);
        public void DateBarInput(string ddmmyy) => DateBar.SendKeys(ddmmyy);
        public void VaccineBarInput(string vaccine) => VaccineDropDown.SendKeys(vaccine);
        public void NameBarInput(string name) => NameDropDown.SendKeys(name);

        public string LocationErrorMessage() => LocationError.Text;
        public string DateErrorMessage() => DateError.Text;
        #endregion
    }
}
