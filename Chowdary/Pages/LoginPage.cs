using Chowdary.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowdary.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // open up chrome browser
            //IWebDriver driver = new ChromeDriver(@"D:\chrome_webdriver");

            // enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // maximize the browser
            driver.Manage().Window.Maximize();

            //Populate Loging Page test data Collection
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\myfri\Source\Repos\pavulurikc\chowdary\Chowdary\TestData\TestData.xls", "LoginPage");

            // identify username and enter username value
            driver.FindElement(By.Id("UserName")).SendKeys(ExcelLibHelpers.ReadData(2,"UserName"));

            // identify password and enter password
            driver.FindElement(By.Id("Password")).SendKeys(ExcelLibHelpers.ReadData(2,"Password"));

            // identify login button and click
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

            // verify if the home page is displayed as expected
            if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
    }
}
