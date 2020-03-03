using Chowdary.Pages;
using Chowdary.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chowdary
{
    class Program
    {
        static void Main(string[] args)
        {
            //// define driver
            //CommonDriver.driver = new ChromeDriver(@"\chrome_webdriver");

            ////page object for Login page
            //LoginPage loginobj = new LoginPage();
            //loginobj.LoginSteps(CommonDriver.driver);

            ////page object for home page
            //HomePage homeobj = new HomePage();
            //homeobj.NavigateToTM(CommonDriver.driver);

            ////page object for TM page
            //TMPage tmobj = new TMPage();

            ////create new TM Test case
            //tmobj.AddTM(CommonDriver.driver);

            // //edit TM test case 
            //tmobj.EditTM(CommonDriver.driver);

            ////delete TM test case
            //tmobj.DeleteTM(CommonDriver.driver);

            //CustomersPage custobj = new CustomersPage();

            ////Create new customer Test
            //custobj.AddCustomerTest();

            //// Edit Customer Test
            //custobj.EditCustomerTest();

            //// Delete Customer Test
            //custobj.DeleteCustomerTest();

        }

    }

    [TestFixture, Description("Time and Material Test Case")]
    class TimeandMaterialTestSuite : CommonDriver
    {
        [SetUp]
        public void Startupsteps()
        {
            // define driver
            driver = new ChromeDriver(@"D:\chrome_webdriver");

            //page object for Login page
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(driver);
        }


        [Test]
        public void AddNewTMTest()
        {
            //page object for home page
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

            //page object for TM page
            TMPage tmobj = new TMPage();

            //create new TM Test case
            tmobj.AddTM(driver);
        }

        [Test]
        public void EditTMTest()
        {
            //page object for home page
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

            //page object for TM page
            TMPage tmobj = new TMPage();

            //edit TM test case 
            tmobj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            //page object for home page
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

            //page object for TM page
            TMPage tmobj = new TMPage();

            //delete TM test case
            tmobj.DeleteTM(driver);
        }

        [TearDown]
        public void FinishTestRun()
        {
            //Close the browser
            driver.Close();
        }
    }

    [TestFixture, Description("Customer Test Cases")]
    class CustomerTestSuite : CommonDriver
    {

        [SetUp]
        public void Startupsteps()
        {
            // define driver
            driver = new ChromeDriver(@"D:\chrome_webdriver");

            //page object for Login page
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(driver);
        }


        [Test]
        public void AddNewCustomerTest()
        {
            //page object for home page
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

            CustomersPage custobj = new CustomersPage();

            //Create new customer Test
            custobj.AddCustomerTest(driver);
        }

        [Test]
        public void EditCustomerTest()
        {
            CustomersPage custobj = new CustomersPage();

            // Edit Customer Test
            custobj.EditCustomerTest(driver);
        }

        [Test]
        public void DeleteCustomerTest()
        {
            CustomersPage custobj = new CustomersPage();

            // Delete Customer Test
            custobj.DeleteCustomerTest(driver);
        }

        [TearDown]
        public void FinishTestRun()
        {
           driver.Close();
        }

    }




}

