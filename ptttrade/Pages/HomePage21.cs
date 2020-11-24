using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace ptttrade.Pages
{
    public class HomePage21 : PageBase
    {
        public HomePage21(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='navbarDropdown'][@class='nav-link text-dark dropdown-toggle pr-4']")]
        public IWebElement SelectLanguageDropdownMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/nav/div/div/div[2]/ul[1]/li[3]/div/a[3]")]
        IWebElement ArabicLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/nav/div/div/div[2]/ul[1]/li[3]/div/a[1]")]
        IWebElement EnglishLanguage { get; set; }


        public void SelectingArabicLanguage()
        {
            SelectLanguageDropdownMenu.Click();
            ArabicLanguage.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void SelectingEnglishLanguage()
        {
            SelectLanguageDropdownMenu.Click();
            EnglishLanguage.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
    }
}
