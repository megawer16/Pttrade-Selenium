using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace ptttrade.Pages
{
    public class PageBase
    {
        public IWebDriver driver;
        public Actions action;
        public PageBase(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
