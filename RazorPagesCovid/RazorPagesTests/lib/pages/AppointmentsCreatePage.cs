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
        //private IWebElement _appointementsButton => Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
        //private IWebElement _createNewButton => Driver.FindElement(By.XPath("/html/body/div/main/p/a"));
        //private IWebElement _vaccineSelectionDropDown => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select"));
        #endregion

        #region methods
        public List<string> CreateContent()
        {
            var list = new List<string>
            {
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

        


        //public void AppointmentstPageByNavBar() => _appointementsButton.Click();
        //public void SelectDropDownForVaccines() => _vaccineSelectionDropDown.Click();
        //public void SelectAllVacines() => _allVaccineSelection.Click();
        //public void SelectJohnsonNJohnsonVacines() => _jnJVaccineSelection.Click();
        //public void SelectModernaVacines() => _modernaVaccineSelection.Click();
        //public void SelectOxfordVacines() => _oxfordVaccineSelection.Click();
        //public void SelectPFizerVacines() => _pFizerVaccineSelection.Click();
        //public void InputSearchableTitle(string title) => _titleSearchBar.SendKeys(title);
        //public void SelectFilter() => _filterButton.Click();
        #endregion
    }
}
