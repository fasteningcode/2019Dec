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
            //LoginPage.LoginSuccess(driver);

            //create instance of class
            LoginPage login = new LoginPage();
            //access the method of class using the instance
            login.LoginSuccess(driver);


            // Create an instance of home page
            HomePage home = new HomePage();

            // create a method to verify the username
            home.VerifyUsername(driver);

            // create a method to click adminstration
            home.ClickAdminstration(driver);

            // create a method to click time n materials
            home.ClickTimenMaterial(driver);


            // click create new


            // enter valid information and click save

            //verify that the time n material object is displayed in the table

            //assignment
            // complete 3 test cases
            // create create time and material and verify
            // edit create time and material and verify
            // delete create time and material and verify

            //close driver
            driver.Quit();
        }

    }
}   
