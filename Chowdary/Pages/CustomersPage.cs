using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chowdary.Pages
{
    class CustomersPage
    {
        public void AddCustomerTest(IWebDriver driver)
        {
            // To Click on Administration button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            // To click on Customer button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

            //To Click on Create New button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //To enter Text in Name field
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("Raj");

            //To Click Edit Contact Button
            driver.FindElement(By.XPath("//*[@id='EditContactButton']")).Click();

            Thread.Sleep(1000);

            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='ContactEditForm']")).FindElement(By.Id("")).SendKeys("");

            //To enter text in FirstName Field
            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys("Raja");
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys("Ram");
            driver.FindElement(By.XPath("//*[@id='Phone']")).SendKeys("0420201047");
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();
            driver.FindElement(By.XPath("//*[@id='EditBillingContactButton']")).Click();

            driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys("Raja");
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys("Ram");
            driver.FindElement(By.XPath("//*[@id='Phone']")).SendKeys("0420201047");
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            // To Click on Administration button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            Thread.Sleep(4000);

            // To click on Customer button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]/span")).Click();

            if (driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]")).Text =="Raja Ram")
            {
                Console.WriteLine("TM created successfully, test passed");
            }
            else
            {
                Console.WriteLine("test failed");
            }

        }

        public void EditCustomerTest(IWebDriver driver)
        {
            
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

           Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[4]/a[1]")).Click();

            driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

            //Verify if the edit time and material record is present.
            if (driver.FindElement(By.XPath("//*[@id='container']/h2")).Text == "Customer")
            {
                Console.WriteLine("TM edited successfully, test passed");
            }
            else
            {
                Console.WriteLine("test failed");
            }
        }

        public void DeleteCustomerTest(IWebDriver driver)
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]/span")).Click();

            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr/td[4]/a[2]")).Click();





        }
    }
}
