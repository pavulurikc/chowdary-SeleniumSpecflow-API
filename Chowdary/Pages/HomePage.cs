using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowdary.Pages
{
    class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            //Identify Administration button and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //Identify Time and Materials button and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
    }
}
