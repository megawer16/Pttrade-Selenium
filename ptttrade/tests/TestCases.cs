using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ptttrade.Pages;
using System;
using Xunit;
namespace ptttrade.tests
{
    public class TestCases
    {
        private const string HomeUrl = "https://www.ptttrade.com/";
        private const string Expected = "https://arabic.ptttrade.com/";
        private HomePage homeObject;

        [Fact]
        public void SelectLanguage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); // to disable notification
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(HomeUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            homeObject = new HomePage(driver);
            homeObject.SelectingArabicLanguage();
            Assert.Equal(Expected, driver.Url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            homeObject.SelectingEnglishLanguage();
            driver.Quit();
        }



    }
}
