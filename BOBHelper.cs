using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyBestBuddy
{
    public static class BOBHelper
    {
        public static string GetExchangeRate()
        {
            //Using headless chrome browser
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
            //Initialize chrome browser with the appropriate options
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "http://www.barodanzltd.co.nz/";
            driver.Navigate();
            string exchangeRate = driver.FindElements(By.TagName("td"))[6].Text;
            driver.Close();
            driver.Quit();
            return exchangeRate;
        }
    }
}
