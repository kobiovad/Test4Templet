using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace TestGlobalElements
{
    public class TestBrokenLinks
    {
        IWebDriver driver = null;
        public ExtentTest test = null;
        public ExtentReports extent = new ExtentReports(); // הטענת המשתנה בטמפלט

        

        [OneTimeSetUp]
        public void ExtentStart()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd"); // ניסיון ליצירת שם דינאמי שישמר
            //extent = new ExtentReports(); // הטענת המשתנה בטמפלט
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Kobi\source\repos\ElementsTemplet\TestGlobalElements\ReportsLogs\er.html");
            extent.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentFinish()
        {
            extent.Flush();// סגירה של הדוח
            driver.Quit();
        }

        [Test]
        public void BlopTestLink() //main(string[] args)
        {
            
            try
            {
                test = extent.CreateTest("ReportTest1").Info("Test Start"); // נגדיר שם ותיאור לטסט
                //string baseUrl = "http://demo.guru99.com/test/newtours/";
                string baseUrl = "http://executeautomation.com/demosite/index.html";
                //string baseUrl = "https://tcb.ac.il/";

                //System.setProperty("webdriver.chrome.driver", "G:\\chromedriver.exe");
                driver = new ChromeDriver();

                string underConsTitle = "404 Not Found";
               // string underConsTitle = "הדף אינו נמצא - המכללה הטכנולוגית באר שבע";
                driver.Manage().Window.Maximize();

                driver.Url = baseUrl;
                IList<IWebElement> linkElements = driver.FindElements(By.TagName("a")); //(By.CssSelector("[href*='http']")
                string[] linkTexts = new string[linkElements.Count];
                int i = 0;

                //extract the link texts of each link element		 
                foreach (IWebElement element in linkElements)
                {
                    linkTexts[i++] = element.Text;
                }

                //test each link		
                foreach (string t in linkTexts)
                {
                    driver.FindElement(By.LinkText(t)).Click();
                    if (driver.Title.Equals(underConsTitle))
                    {
                        test.Log(Status.Warning, "\"" + t + "\"" + " is under construction.");
                        Console.WriteLine("The : "+ "\"" + t + "\"" + " is under construction.");

                    }

                    else
                    {
                        test.Log(Status.Pass, "\"" + t + "\"" + " is working.");
                        Console.WriteLine("The : " + "\"" + t + "\"" + " is working.");

                    }
                    if (driver.Url != baseUrl)
                        driver.Navigate().Back();
                }
                
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());//רישום הבעיה במסוף הדוחות
                Console.WriteLine("Faill - " , e.ToString());//רישום הבעיה במסוף הדוחות

            }        
        }
    }
}

