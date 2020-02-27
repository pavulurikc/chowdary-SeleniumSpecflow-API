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
            // open up chrome browser
            IWebDriver driver = new ChromeDriver(@"D:\chrome_webdriver");
            // enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            // maximize the browser
            driver.Manage().Window.Maximize();
            // identify username and enter username value
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            // identify password and enter password
            driver.FindElement(By.Id("Password")).SendKeys("123123");
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
            //Identify Administration button and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Identify Time and Materials button and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            //Identify create New button and click
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            //enter a code field
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("100");
            //cnter a description field
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("abc");
            //enter a save field
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            //wait
            Thread.Sleep(1000);
            //Goto last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            //Verify if the created time and material record is present.
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[1]")).Text == "100")
            {
                Console.WriteLine("TM created successfully, test passed");
            }
            else
            {
                Console.WriteLine("test failed");
            }

            driver.FindElement(By.XPath("//*[@id="tmsGrid"]/div[3]/table/tbody/tr[6]/td[5]/a[1]")).Click();

        }
    }

}

