using System;
using OpenQA.Selenium;

namespace _2019DecNunit
{
    public class LoginPage
    {
        IWebDriver driver; 

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement userName => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement logInbtn => driver.FindElement(By.XPath("//input[@value='Log in']"));


        public void LoginSuccess()
        {
            //identify & enter UN & PW
            userName.SendKeys("hari");
            //identify and enter password
            password.SendKeys("123123");

            //click Login
            //back slash character for string
            // identfying using xpath
            logInbtn.Click();
            //*[@id="loginForm"]/form/div[3]/input[1]

        }
    }
}
