using Microsoft.Azure.Amqp.Framing;
using MimeKit;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Header = Microsoft.Azure.Amqp.Framing.Header;

namespace ptttrade.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        Actions action;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            action = new Actions(driver);
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
