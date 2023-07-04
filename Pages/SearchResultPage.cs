using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.wait = wait;
        }

        public bool IsCourseDisplayed(string courseName)
        {
            IWebElement courseElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[contains(text(), 'Result for \"{courseName}\"')]")));
            return courseElement.Displayed;

        }

        public void ApplyDeliveryFilter(string filterOption)
        {
            IWebElement deliveryFilter = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("delivery-filter")));
            SelectElement selectElement = new SelectElement(deliveryFilter);
            selectElement.SelectByText(filterOption);
        }
        public bool IsDeliveryFilterApplied(string filterOption)
        {
            IWebElement selectedOption = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//option[@selected='selected' and text()='{filterOption}']")));
            return selectedOption.Displayed;
        }
    }
}
