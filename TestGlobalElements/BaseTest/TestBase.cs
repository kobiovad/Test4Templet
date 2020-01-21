using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestGlobalElements.BaseTest
{

    public class TestBase
    {
        public IWebDriver driver;
        
        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.tcb.ac.il/";

        }

         
        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(5000); // השהייה לפני סגירה
            driver.Close();
        }

    }
}
