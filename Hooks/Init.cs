using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TAFENSW.Steps;
using TAFENSW.Pages;

namespace TAFENSW.Hooks
{
    [Binding]
    public class Init
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Set up ChromeDriver
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Quit the WebDriver
            driver.Quit();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public WebDriverWait GetWait()
        {
            return wait;
        }

       
    }
}
