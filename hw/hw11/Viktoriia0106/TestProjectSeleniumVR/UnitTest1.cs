using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //create a new instance of the ChromeDriver (open a new Chrome browser window)
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            // Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Wait for 2 seconds to allow the page to load (Google window opening)
            Thread.Sleep(2000);

            // Check that the title contains "Google"
            Assert.That(driver.Title, Does.Contain("Google"));
        }

        [TearDown]
        public void CloseBrowser()
        {
            // Close the browser and quit the driver
            driver.Quit();
        }
    }
}