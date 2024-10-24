using OpenQA.Selenium;

namespace Namaa.Pages
{
    internal class ExamplePage: BasePage
    {
        public ExamplePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement MORE_INFO => driver.FindElement(By.PartialLinkText("More information"));

        public void NavigateToExamplePage()
        {
            driver.Navigate().GoToUrl("https://example.com/");
        }
        public void GoToMoreInfoPage()
        {
            MORE_INFO.Click();
        }
    }
}
