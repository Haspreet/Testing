using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;

namespace TestingApplication
{
    class CheckBox
    {
        IWebDriver driver = new FirefoxDriver();
        public void raioButton() {
            string URL = "http://toolsqa.com/automation-practice-form/";
            driver.Navigate().GoToUrl(URL);
            IList<IWebElement> buttons = driver.FindElements(By.Name("exp"));
            int buttonCount = buttons.Count;
            for (int i =0; i<=buttonCount; i++) {
                try
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#exp-" + i));
                    element.Click();
                }
                catch (NoSuchElementException) {
                    Console.WriteLine("All the elment already selected or no such element");
                    driver.Quit();
                }
            }

        }
    }
}
