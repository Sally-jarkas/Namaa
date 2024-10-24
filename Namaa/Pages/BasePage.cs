using OpenQA.Selenium;

namespace Namaa.Pages
{
    internal class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
         }


    }
}
