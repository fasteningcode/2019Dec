using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _2019Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            // add reference to selenium
            // add reference to browser (eg: chrome)

            //open a chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //identify & enter UN & PW
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");

            //click Login

            // verify that the username is displayed
        }


    }
}   
