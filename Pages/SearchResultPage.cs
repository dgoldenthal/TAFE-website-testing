using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using TAFENSW.Steps;

namespace TAFENSW.Pages
{
    public class SearchResultPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SearchResultPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public bool IsCourseDisplayed(string courseName, WebDriverWait wait)
        {
            string xpath = $"//h2[contains(., \"{courseName}\")]";
            try
            {
                IWebElement courseElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
                return courseElement.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        public void ApplyDeliveryFilter(string filterOption, WebDriverWait wait)
        {
            IWebElement deliveryFilter = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(text(), 'Delivery')]")));
            IWebElement filterElement = deliveryFilter.FindElement(By.XPath("./span"));
            filterElement.Click();
            IWebElement filterOptionElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//input[@id='{filterOption.ToLower().Replace(" ", "-")}']")));
            filterOptionElement.Click();
        }
        
        public bool IsDeliveryFilterApplied(string filterOption, WebDriverWait wait)
        {
            string expectedFilterText = $"{filterOption}";
            try
            {
                IWebElement filterElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//button[contains(., '{expectedFilterText}')]")));
                return filterElement.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
