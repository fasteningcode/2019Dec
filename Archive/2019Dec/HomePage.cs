using System;
using OpenQA.Selenium;

namespace _2019Dec
{
    internal class HomePage
    {
        internal void VerifyUsername(IWebDriver driver)
        {
            // verify that the username is displayed
            IWebElement txtUserName = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Hello hari!')]"));

            if (txtUserName.Text == "Hello hari!")
                Console.WriteLine("Verified the username");
            else
                Console.WriteLine("Test failed to find the username");

        }

        internal void ClickAdminstration(IWebDriver driver)
        {
            // click on adminstration
            driver.FindElement(By.XPath("//a[contains(.,'Administration')]")).Click();
        }

        internal void ClickTimenMaterial(IWebDriver driver)
        {

            // click on time n materials
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();

        }
    }
}