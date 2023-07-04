using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFENSW.Steps;
using TAFENSW.Hooks;

namespace TAFENSW.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void SearchCourse(string courseName)
        {

            // Find the search input element
            System.Threading.Thread.Sleep(5000);
            IWebElement searchInput = driver.FindElement(By.CssSelector("div.relative.flex-1 > input#headerSearch"));


            // Click on the search input element
            searchInput.Click();

            // Enter the search query
            searchInput.SendKeys(courseName);

            // Press the Enter key to submit the search
            searchInput.SendKeys(Keys.Enter);
        }
    }
}
