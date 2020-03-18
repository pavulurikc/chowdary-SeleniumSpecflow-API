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

            //Populate Loging Page test data Collection
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\myfri\Source\Repos\pavulurikc\chowdary\Chowdary\TestData\TestData.xls", "CustomerPage");

            //To enter Text in Name field
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys(ExcelLibHelpers.ReadData(2, "Name"));

            //To Click Edit Contact Button
            driver.FindElement(By.XPath("//*[@id='EditContactButton']")).Click();

            Thread.Sleep(1000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='contactDetailWindow']/iframe")));

            
            //To enter text in FirstName Field
            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys(ExcelLibHelpers.ReadData(2, "FirstName"));
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys(ExcelLibHelpers.ReadData(2, "LastName"));
            driver.FindElement(By.XPath("//*[@id='Phone']")).SendKeys(ExcelLibHelpers.ReadData(2, "Phone"));
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            driver.SwitchTo().DefaultContent();

            driver.FindElement(By.XPath("//*[@id='EditBillingContactButton']")).Click();

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='contactDetailWindow']/iframe")));
            Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//*[@id='IsSameContact']")).Click();

            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys(ExcelLibHelpers.ReadData(2, "FirstName"));
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys(ExcelLibHelpers.ReadData(2, "LastName"));
            driver.FindElement(By.XPath("//*[@id='Phone']")).SendKeys(ExcelLibHelpers.ReadData(2, "Phone"));
            //Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            // To Click on Administration button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            // To click on Customer button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]/span")).Click();

            if (driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]")).Text =="Ram")
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
            // To click on the Admonistration button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //To click on the Customer Name button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

           Thread.Sleep(3000);

            //To Navigate to Last Page
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]/span")).Click();

            //To Edit last Element of the page
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[4]/a[1]")).Click();

            //driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

            //Switch to child Windoe
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='detailWindow']/iframe")));

            Thread.Sleep(2000);

            //Verify if the edit time and material record is present.
            
            
            if (driver.FindElement(By.XPath("//*[@id='detailWindow_wnd_title']")).Text == "Edit Client")
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
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]/span")).Click();

            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr/td[4]/a[2]")).Click();





        }
    }
}
