
using Namaa.Pages;

namespace Namaa
{
    internal class Example : BaseTest
    {


        [Test]
        public void TestNavigation()
        {
            ExamplePage examplePage = new ExamplePage(GetDriver());
            AboutPage aboutPage = new AboutPage(GetDriver());
            examplePage.NavigateToExamplePage();
            Assert.That(GetPageTitle(), Is.EqualTo("Example Domain"));
            examplePage.GoToMoreInfoPage();
            Assert.That(GetDriver().Url, Is.EqualTo("https://www.iana.org/help/example-domains"));

            NavigateTo("https://www.iana.org/about");
            ScrollToTheBottom();
            aboutPage.GoToTerms();
            Assert.That(GetPageTitle().ToLower(), Does.Contain("terms of service"));
        }
    }
}
