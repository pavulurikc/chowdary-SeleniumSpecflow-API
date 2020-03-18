using Chowdary.Utilities;
using NUnit.Framework;
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

            //Populate Loging Page test data Collection
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\myfri\Source\Repos\pavulurikc\chowdary\Chowdary\TestData\TestData.xls", "TMPage");

            //enter a code field
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys(ExcelLibHelpers.ReadData(2, "Code"));

            //cnter a description field
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys(ExcelLibHelpers.ReadData(2, "Description"));

            //enter a save field
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //wait
            Thread.Sleep(1000);

            //Goto last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text, Is.EqualTo("100"));


            ////Verify if the created time and material record is present.
            
            //if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "100")
            //{
                
            //    Console.WriteLine("TM created successfully, test passed");
            //}
            //else
            //{
            //    Console.WriteLine("test failed");
            }


            //}

        public void EditTM(IWebDriver driver) 
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            Assert.That(driver.FindElement(By.XPath("//*[@id='container']/h2")).Text, Is.EqualTo("Time and Materials"));

            ////Verify if the edit time and material record is present.
            //if (driver.FindElement(By.XPath("//*[@id='container']/h2")).Text == "Time and Materials")
            //{
            //    Console.WriteLine("TM edited successfully, test passed");   
            //}
            //else
            //{
            //    Console.WriteLine("test failed");
            //}
        }

        public void DeleteTM(IWebDriver driver)
        {

            //{
            //    Thread.Sleep(4000);
            //    string countBeforeDelete = driver.FindElement(By.XPath(".//*[@data-role='pager']")).Text.Remove(0, 150);
            //    Console.WriteLine(countBeforeDelete);
            //}

            //To click on Administration 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //To click on Time & Materials
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

            Thread.Sleep(2000);

            //To click on Last page button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            String value = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/span[2]")).GetAttribute("Value");
            Console.WriteLine(value);

            // To click on Delete button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();

            //To accept the pop-up window
            driver.SwitchTo().Alert().Accept();

            //string beforeDel = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/span[2]")).Text.Remove(0, 9);
            //Console.WriteLine(beforeDel);
            //string numberBefore = beforeDel.Remove(beforeDel.Length - 5);
            //Console.WriteLine(numberBefore);


            //IList<IWebElement> totalno= driver.FindElements(By.XPath("//*[@id='tmsGrid']/div[2]/div/table/thead/tr/th[1]/a"));
            // Console.WriteLine("Total Counts: " + totalno.Count);
            // Console.ReadKey();

            // //for(int i=0;i<totalno.Count;i++)
            // //{
            // //    Console.WriteLine(totalno[i].)
            // //}







        }
    }
}

