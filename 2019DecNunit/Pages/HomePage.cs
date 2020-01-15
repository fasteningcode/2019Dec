using System;
using OpenQA.Selenium;

namespace _2019DecNunit
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //IWebDriver driver;

        //public HomePage(IWebDriver driver)
        //{
        //    driver = driver;
        //}

        internal void VerifyUsername()
        {
            // verify that the username is displayed
            IWebElement txtUserName = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Hello hari!')]"));

            if (txtUserName.Text == "Hello hari!")
                Console.WriteLine("Verified the username");
            else
                Console.WriteLine("Test failed to find the username");

        }

        internal void ClickAdminstration()
        {
            // click on adminstration
            driver.FindElement(By.XPath("//a[contains(.,'Administration')]")).Click();
        }

        internal void ClickTimenMaterial()
        {

            // click on time n materials
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();

        }
    }
}
