using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Namaa
{
    /// <summary>
    /// This Class contains the basic methods needed for testing
    /// </summary>
    internal class BaseTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setting Up ....");
            driver = CreateDriver(ConfigurationProvider.Configuration["browser"]);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
            driver.Dispose();
            TestContext.Progress.WriteLine("Closed ....");
        }
        private IWebDriver CreateDriver(string browser)
        {
            switch (browser.ToLowerInvariant())
            {
                case "chrome":
                    return new ChromeDriver();
                case "firefox":
                    return new FirefoxDriver();
                case "internetexplorer":
                    return new InternetExplorerDriver();
                default:
                    throw new ArgumentException("The Browser is not supported");
            }
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public void ScrollToTheBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;           
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
    }
}
