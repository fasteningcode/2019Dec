using System;
using OpenQA.Selenium;

namespace _2019Dec
{
    internal class TimeMaterialPage
    {
        public TimeMaterialPage()
        {
        }

        internal void ClickCreateNew(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
        }

        internal void EnterValidDetails(IWebDriver driver)
        {
            driver.FindElement(By.Id("Code")).SendKeys("2019DeCcode");
            driver.FindElement(By.Name("Description")).SendKeys("Descriotn s");

            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("99");
            driver.FindElement(By.Id("SaveButton")).Click();

        }
    }
}