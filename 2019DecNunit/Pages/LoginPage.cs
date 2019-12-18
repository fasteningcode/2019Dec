using System;
using OpenQA.Selenium;

namespace _2019DecNunit
{
    public class LoginPage
    {
        public void LoginSuccess(IWebDriver driver)
        {
            //identify & enter UN & PW
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");

            //identify and enter password
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            //click Login
            //back slash character for string
            // identfying using xpath
            IWebElement logInbtn = driver.FindElement(By.XPath("//input[@value='Log in']"));
            logInbtn.Click();
            //*[@id="loginForm"]/form/div[3]/input[1]

        }
    }
}
