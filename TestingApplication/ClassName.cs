using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingApplication
{
    class ClassName
    {
        IWebDriver driver = new ChromeDriver();
        MessageColor mColor = new MessageColor();
        public void FoundByClass()
        {
            string url = "http://testing.todvachev.com/selectors/class-name/";
            string ClassName = "testClass";
            try
            {
                driver.Navigate().GoToUrl(url);
                IWebElement element = driver.FindElement(By.ClassName(ClassName));
                if (element.Displayed)
                {
                    mColor.GreenMessage("Found the element By class " + ClassName + "");
                    mColor.GreenMessage(element.Text);
                }

            }
            catch (NoSuchElementException)
            {

                mColor.ReadMessage("Element via this className does not exist");
            }
        }
        public void ByNameSelector()
        {

            string url1 = "http://testing.todvachev.com/selectors/name/";
            string name = "myName";
            try
            {
                driver.Navigate().GoToUrl(url1);
                IWebElement element = driver.FindElement(By.Name(name));
                if (element.Displayed)
                {
                    mColor.GreenMessage("we find the elemet by name selector =="+ name);
                    Thread.Sleep(5000);
                }
            }
            catch (NoSuchElementException)
            {

                mColor.ReadMessage("We are unable to find the element by given name selector ==" + name);
            }
        }


    }
}
