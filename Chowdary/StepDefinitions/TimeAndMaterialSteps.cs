using Chowdary.Pages;
using Chowdary.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Chowdary.StepDefinitions
{
    [Binding]
    class TimeAndMaterialSteps : CommonDriver
    {
        [Given(@"I have logged in TurnUp Portal")]
        public void GivenIHaveLoggedInTurnUpPortal()
        {
            // define driver
            driver = new ChromeDriver(@"D:\chrome_webdriver");

            //page object for Login page
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(driver);
        }
        
        [Given(@"I navigate to Time and Material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            //page object for home page
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);
        }

        [Then(@"I should be able to create time record with valid information")]
        public void ThenIShouldBeAbleToCreateTimeRecordWithValidInformation()
        {
            //page object for TM page
            TMPage tmobj = new TMPage();

            //create new TM Test case
            tmobj.AddTM(driver);
        }

        [Then(@"I should be able to edit time record with updated information")]
        public void ThenIShouldBeAbleToEditTimeRecordWithUpdatedInformation()
        {
            //page object for TM page
            TMPage tmobj = new TMPage();

            //edit TM test case 
            tmobj.EditTM(driver);
        }
    }
}
