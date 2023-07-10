using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using TAFENSW.Pages;


namespace TAFENSW.Steps
{
    [Binding]
    public class TAFEWebsiteTest
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

            [BeforeTestRun]
            public static void CourseSearchSteps()
            {
                // Set up ChromeDriver
                driver = new ChromeDriver();
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                // open browser and maximize it
                driver.Manage().Window.Maximize();
            }


            [Given(@"I am on the TAFE NSW website")]
            public void GivenIAmOnTheTAFENSWWebsite()
            {
                driver.Navigate().GoToUrl("https://www.tafensw.edu.au/");
            }

            [When(@"I search for a course with name '(.*)'")]
            public void WhenISearchForACourseWithName(string courseName)
            {
                HomePage homePage = new HomePage(driver, wait);
                homePage.SearchCourse(courseName);
            }


            [Then(@"the search results should display the course '(.*)'")]
            public void ThenTheSearchResultsShouldDisplayTheCourse(string courseName)
            {
                SearchResultPage searchResultPage = new SearchResultPage(driver, wait);
                Assert.IsTrue(searchResultPage.IsCourseDisplayed(courseName, wait));
            }

            [When(@"I apply the delivery filter as '(.*)'")]
            public void WhenIApplyTheDeliveryFilterAs(string filterOption)
            {
                SearchResultPage searchResultPage = new SearchResultPage(driver, wait);
                searchResultPage.ApplyDeliveryFilter(filterOption,wait);
            }

            [Then(@"the filter should be applied correctly to the chosen course '(.*)'")]
            public void ThenTheFilterShouldBeAppliedCorrectlyToTheChosenCourse(string filterOption)
            {
                SearchResultPage searchResultPage = new SearchResultPage(driver, wait);
                Assert.IsTrue(searchResultPage.IsDeliveryFilterApplied(filterOption,wait));
            }

            [AfterTestRun]
            public static void AfterTestRun()
            {
                driver.Quit();
            }

    }
}
