using System;
using System.Threading;
using OpenQA.Selenium;

namespace _2019DecNunit
{
    public class TimeMaterialPage
    {
       
        public TimeMaterialPage()
        {
        }
        string codeString = "";

        internal void ClickCreateNew(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
        }

        internal void EnterValidDetails(IWebDriver driver)
        {
            driver.FindElement(By.Id("Code")).SendKeys(codeString);
            driver.FindElement(By.Name("Description")).SendKeys("Descriotn s");

            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("99");
            driver.FindElement(By.Id("SaveButton")).Click();

        }

        internal void ValidateDetails(IWebDriver driver)
        {

            Thread.Sleep(2000);
            try
            {
                while (true)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        //IWebElement descP = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[3]"));

                        Console.WriteLine(code.Text);

                        if (code.Text == codeString)
                           //&& (descP.Text == "Descriotn s"))
                        {
                            Console.WriteLine("Test passed");
                            return;
                        }
                    }
                    driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test failed");
            }
            
        }
    }
}


