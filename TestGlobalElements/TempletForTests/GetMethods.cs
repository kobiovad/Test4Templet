using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;


namespace TestGlobalElements
{
    class GetMethods
    {
        public static string GetText(IWebDriver driver, string element, PropertyType elementType) //PropertyType --  משתנה אינעם קבוע כך שלא יהיה ניתן להתבלבל
        {
            switch (elementType)
            {
                case PropertyType.Id:
                    return driver.FindElement(By.Id(element)).GetAttribute("value");
                case PropertyType.Name:
                    return driver.FindElement(By.Name(element)).GetAttribute("value");
                case PropertyType.Xpath:
                    return driver.FindElement(By.XPath(element)).GetAttribute("value");
                default:
                    return String.Empty;// Console.WriteLine("No found " + element + " with this value: " + value + " ");
            }
            
        }
        public static string GetTextDropDownList(IWebDriver driver, string element, PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertyType.Id:
                    return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;  
                case PropertyType.Name:
                    return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
                case PropertyType.Xpath:
                    return new SelectElement(driver.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
                default:
                    return String.Empty;// Console.WriteLine("No found " + element + " with this value: " + value + " ");
            }

        }
    }
}
