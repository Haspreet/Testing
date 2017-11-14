using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingApplication
{
    class InputText
    {
        public void checkInbox()
        {
         string url = "http://testing.todvachev.com/special-elements/text-input-field/";
         string name = "username";
         IWebDriver driver1 = new ChromeDriver();
         MessageColor mColor = new MessageColor();
         driver1.Navigate().GoToUrl(url);
            try
            {
                IWebElement elment = driver1.FindElement(By.Name(name));
                elment.SendKeys("Hello here is texts");
                Thread.Sleep(5000);
                mColor.GreenMessage(elment.Text);
                mColor.GreenMessage("The maxlength of the Input field == " + elment.GetAttribute("maxlength"));
                driver1.Quit();
            }
            catch (NoSuchElementException) {
                mColor.GreenMessage("The elwmwnt is not present on the page. :(");
                driver1.Quit();

            }
         }
    }
 }

