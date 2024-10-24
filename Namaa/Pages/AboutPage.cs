using OpenQA.Selenium;

namespace Namaa.Pages
{
    internal class AboutPage : BasePage
    {
        public AboutPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement TERMS_LINK => driver.FindElement(By.PartialLinkText("Terms of Service"));


        public void GoToTerms()
        {
            TERMS_LINK.Click();
        }
    }
}
