using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;

namespace TestGlobalElements.TempletForTests
{
     class TempClassTest
    {
        public static void EnterText(IWebDriver driver,string element,string value,PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertyType.Id:
                    driver.FindElement(By.Id(element)).SendKeys(value);
                    break;
                case PropertyType.Name:
                     driver.FindElement(By.Name(element)).SendKeys(value);
                    break;
                case PropertyType.Xpath:
                    driver.FindElement(By.XPath(element)).SendKeys(value);
                    break;
                default:
                    Console.WriteLine("No found " + element + " with this value: " + value + " ");
                    break;
            }            
        }

        //[FindsBy(How = How.XPath, Using = "kobi")]
        //public IWebElement ChannelName { get; set; }
        //public string getName()
        //{
        //    return ChannelName.Text;

        //}


        public static void ClickOn(IWebDriver driver, string element, PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertyType.Id:
                    driver.FindElement(By.Id(element)).Click();
                    break;
                case PropertyType.Name:
                    driver.FindElement(By.Name(element)).Click();
                    break;
                case PropertyType.Xpath:
                    driver.FindElement(By.XPath(element)).Click();
                    break;
                default:
                    Console.WriteLine("Not Clicked on - " + element + " with this elementType: " + elementType + " ");
                    break;
            }          
        }
        public static void SelectDropDown(IWebDriver driver, string element, string value, PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertyType.Id:
                    new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
                    break;
                case PropertyType.Name:
                    new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
                    break;
                case PropertyType.Xpath:
                    new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
                    break;
                default:
                    Console.WriteLine("Not found " + element + " with this value: " + value + " ");
                    break;
            } 
            
        }
        public static void scrollDown(IWebDriver driver)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,350);");
        }
    }
}
