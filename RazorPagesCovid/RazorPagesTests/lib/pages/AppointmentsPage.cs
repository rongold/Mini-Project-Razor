using OpenQA.Selenium;

namespace RazorPagesTests.lib.pages
{
    class AppointmentsPage
    {
        public AppointmentsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region properties
        public IWebDriver Driver { get; }
        private string _url = AppConfigReader.AppointmentsURL;
        private IWebElement _appointementsButton => Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
        private IWebElement _createNewButton => Driver.FindElement(By.XPath("/html/body/div/main/p/a"));
        private IWebElement _vaccineSelectionDropDown => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select"));
        private IWebElement _allVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[1]"));
        private IWebElement _jnJVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[2]"));
        private IWebElement _modernaVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[3]"));
        private IWebElement _oxfordVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[4]"));
        private IWebElement _pFizerVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[5]"));
        private IWebElement _titleSearchBar => Driver.FindElement(By.XPath("/html/body/div/main/form/p/input[1]"));
        private IWebElement _filterButton => Driver.FindElement(By.XPath("/html/body/div/main/form/p/input[2]"));
        #endregion

        #region methods
        public string GetUrl() => _url;
        public void VistitPageByURL() => Driver.Navigate().GoToUrl(_url);
        public void VistitPageByNavBar() => _appointementsButton.Click();
        public void CreateAppointment() => _createNewButton.Click();
        public void SelectDropDownForVaccines() => _vaccineSelectionDropDown.Click();
        public void SelectAllVacines() => _allVaccineSelection.Click();
        public void SelectJohnsonNJohnsonVacines() => _jnJVaccineSelection.Click();
        public void SelectModernaVacines() => _modernaVaccineSelection.Click();
        public void SelectOxfordVacines() => _oxfordVaccineSelection.Click();
        public void SelectPFizerVacines() => _pFizerVaccineSelection.Click();
        public void InputSearchableTitle(string title) => _titleSearchBar.SendKeys(title);
        public void SelectFilter() => _filterButton.Click();
        #endregion
    }
}
