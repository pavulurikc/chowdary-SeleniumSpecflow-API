using Chowdary.Pages;
using Chowdary.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Chowdary.StepDefinitions
{
    [Binding]
     class CustomerSteps : CommonDriver
    {
        [Given(@"I logged in to TurnUp Portal")]
        public void GivenILoggedInToTurnUpPortal()
        {
            // define driver
            driver = new ChromeDriver(@"D:\chrome_webdriver");

            //page object for Login page
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(driver);
        }

        [Given(@"I navigate to Customer page")]
        public void GivenINavigateToCustomerPage()
        {
            //page object for home page
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

        }
        
        [Then(@"I should be able to create Customer record with valid information")]
        public void ThenIShouldBeAbleToCreateCustomerRecordWithValidInformation()
        {
            CustomersPage custobj = new CustomersPage();

            //Create new customer Test
            custobj.AddCustomerTest(driver);
        }

        [Then(@"I should be able to edit Customer record with updated information")]
        public void ThenIShouldBeAbleToEditCustomerRecordWithUpdatedInformation()
        {
            CustomersPage custobj = new CustomersPage();

            // Edit Customer Test
            custobj.EditCustomerTest(driver);
        }
    }
}
