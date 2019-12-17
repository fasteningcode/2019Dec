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

            //accessing static method
            LoginPage.LoginSuccess(driver);

            // verify that the username is displayed
            IWebElement txtUserName =  driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Hello hari!')]"));

            if (txtUserName.Text == "Hello hari!")
                Console.WriteLine("Verified the username");
            else
                Console.WriteLine("Test failed to find the username");

            // click on adminstration
            driver.FindElement(By.XPath("//a[contains(.,'Administration')]")).Click();

            // click on time n materials
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();

            // click create new


            // enter valid information and click save

            //verify that the time n material object is displayed in the table

            //assignment
            // complete 3 test cases
            // create create time and material and verify
            // edit create time and material and verify
            // delete create time and material and verify
        }

    }
}   
