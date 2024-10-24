
using OpenQA.Selenium;

namespace Namaa
{
    internal class Example:BaseTest
    {

        [Test]
        public void TestNavigation()
        {
            NavigateTo("https://example.com/");
            Assert.That(GetPageTitle(), Is.EqualTo("Example Domain"));
            GetDriver().FindElement(By.PartialLinkText("More information")).Click();
            Assert.That(GetDriver().Url, Is.EqualTo("https://www.iana.org/help/example-domains"));
            NavigateTo("https://www.iana.org/about");
            ScrollToTheBottom();
            GetDriver().FindElement(By.PartialLinkText("Terms of Service")).Click();
            Assert.That(GetPageTitle().ToLower(), Does.Contain("terms of service"));
        }
    }
}
