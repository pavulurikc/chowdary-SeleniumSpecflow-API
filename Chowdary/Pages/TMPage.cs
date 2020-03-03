using Chowdary.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chowdary.Pages
{
    class TMPage
    {
        public void AddTM(IWebDriver driver)
        {
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
            
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "100")
            {
                Console.WriteLine("TM created successfully, test passed");
            }
            else
            {
                Console.WriteLine("test failed");
            }


            }

        public void EditTM(IWebDriver driver) 
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            //Verify if the edit time and material record is present.
            if (driver.FindElement(By.XPath("//*[@id='container']/h2")).Text == "Time and Materials")
            {
                Console.WriteLine("TM edited successfully, test passed");   
            }
            else
            {
                Console.WriteLine("test failed");
            }
        }

        public void DeleteTM(IWebDriver driver)
        {
            //To click on save button
            //driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //To click on Last page button
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(2000);

            string recordCount = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/span[2]")).Text;

            Console.WriteLine(recordCount);


            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            //driver.SwitchTo().Alert().Accept();

            ////Verify if the created time and material record is present.
            //if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]")).Text == "100")
            //{
            //    Console.WriteLine("TM deleted successfully, test passed");
            //}
            //else
            //{
            //    Console.WriteLine("test failed");
            //}
        }
    }
}
