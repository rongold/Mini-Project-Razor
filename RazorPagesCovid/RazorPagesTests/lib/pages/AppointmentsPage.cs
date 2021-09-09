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
        private string _url_Home = AppConfigReader.HomePageUrl;
        private string _url_App = AppConfigReader.AppointmentsURL;

        private IWebElement Title => Driver.FindElement(By.XPath("/html/body/div/main/h1"));
        private IWebElement AppointementsButton => Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
        private IWebElement CreateNewButton => Driver.FindElement(By.XPath("/html/body/div/main/p/a"));
        private IWebElement VaccineSelectionDropDown => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select"));
        private IWebElement AllVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[1]"));
        private IWebElement JnJVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[2]"));
        private IWebElement ModernaVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[3]"));
        private IWebElement OxfordVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[4]"));
        private IWebElement PFizerVaccineSelection => Driver.FindElement(By.XPath("/html/body/div/main/form/p/select/option[5]"));
        private IWebElement TitleSearchBar => Driver.FindElement(By.XPath("/html/body/div/main/form/p/input[1]"));
        private IWebElement FilterButton => Driver.FindElement(By.XPath("/html/body/div/main/form/p/input[2]"));
        #endregion

        #region methods
        public string GetUrl() => _url_App;
        public string GetCurrentUrl() => Driver.Url;
        public void HomePage() => Driver.Navigate().GoToUrl(_url_Home);
        public void VistitPageByURL() => Driver.Navigate().GoToUrl(_url_App);
        public void ClickCreateNew() => CreateNewButton.Click();
        public string GetTitleValue() => Title.Text;

        public void AppointmentstPageByNavBar() => AppointementsButton.Click();
        public void SelectDropDownForVaccines() => VaccineSelectionDropDown.Click();
        public void SelectAllVacines() => AllVaccineSelection.Click();
        public void SelectJohnsonNJohnsonVacines() => JnJVaccineSelection.Click();
        public void SelectModernaVacines() => ModernaVaccineSelection.Click();
        public void SelectOxfordVacines() => OxfordVaccineSelection.Click();
        public void SelectPFizerVacines() => PFizerVaccineSelection.Click();
        public void InputSearchableTitle(string title) => TitleSearchBar.SendKeys(title);
        public void SelectFilter() => FilterButton.Click();
        #endregion
    }
}
