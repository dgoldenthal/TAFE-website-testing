# TAFENSW
TAFE NSW Website Test Automation
This repository contains an automated test suite for the TAFE NSW website using Selenium, C#, SpecFlow, and NUnit. The test suite covers the functionality of searching for a course and applying a delivery filter.

Prerequisites
Make sure you have the following software installed on your machine:

Visual Studio or any other C# IDE
Chrome browser
Getting Started
Clone this repository to your local machine.
Open the solution in Visual Studio.
Test Framework Overview
The test framework is built using the following technologies and concepts:

Selenium WebDriver: Used for automating browser interactions.
SpecFlow: A behavior-driven development (BDD) framework that allows writing test scenarios in Gherkin syntax.
NUnit: A unit testing framework used for running and managing tests.
Page Object Model (POM): A design pattern that helps in creating reusable and maintainable page objects for interacting with web elements.
Project Structure
The project is organized into the following folders:

Pages: Contains page object classes that represent the different pages of the TAFE NSW website.
Steps: Contains the step definitions for the SpecFlow scenarios.
Features: Contains the Gherkin feature files that define the test scenarios.
Running the Tests
To run the automated tests, follow these steps:

Open the Test Explorer window in Visual Studio (Test -> Test Explorer).
Click on the Run All Tests button in the Test Explorer window.
The tests will be executed, and the test results will be displayed in the Test Explorer window.
Test Scenario Description
The test scenario defined in the tafeNSW.feature file verifies the course search and delivery filter functionality. The scenario is divided into the following steps:

Given I am on the TAFE NSW website: Navigates to the TAFE NSW website.
When I search for a course with name '...': Enters a course name in the search input and submits the search.
Then the search results should display the course '...': Verifies if the search results display the expected course.
When I apply the delivery filter as '...': Applies a delivery filter option.
Then the filter should be applied correctly to the chosen course '...': Verifies if the applied filter is correctly displayed for the chosen course.
