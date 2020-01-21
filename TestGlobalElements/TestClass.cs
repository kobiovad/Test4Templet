
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TestGlobalElements.BaseTest;
using TestGlobalElements.TempletForTests;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;

namespace TestGlobalElements
{
    [TestFixture]
    public class TestClass : TestBase
    {
        [Test]
        public void TestMethod()
        {
            //LinqLibaryTest.linqList();
            //Blop Example!!!
            TempClassTest.EnterText(driver, ".//*[@name='fullname']", "kobi", PropertyType.Xpath);
            string expectedName = GetMethods.GetText(driver, ".//*[@name='fullname']", PropertyType.Xpath);
            TempClassTest.SelectDropDown(driver, ".//*[@name='subject']", "הנדסת חשמל", PropertyType.Xpath);   
            //GetMethods.GetText(driver, ".//*[@name='fullname']",PropertyType.Xpath);
            string actualName = "kobi";
            Assert.AreEqual(expectedName, actualName);
            
            //Console.WriteLine("The Value is: "+GetMethods.GetText(driver, ".//*[@name='fullname']", "XPath"));
            //TestBrokenLinks testBrokenLinks = new TestBrokenLinks();
            //testBrokenLinks.BlopTestLink();

            // חשוב שהפונקציה תהיה סטטית
            // בנוסף כדי להפעיל את הפונקציה נוריד את ההורשה בדף הראשי פה 
            //Console.WriteLine("The Value is: " + GetMethods.GetText(driver, ".//*[@name='subject']", PropertyType.Xpath));



            //TempClassTest.scrollDown(driver);
            //TempClassTest.EnterText(driver, ".//*[@name='phone']", "0541234567", "XPath");
            //TempClassTest.EnterText(driver, ".//*[@name='email']", "blop@blop.blop", "XPath");
            // TempClassTest.ClickOn(driver, "", "XPath");
        }
        [Test]
       public void TestWithPom()
        {

        }

    }
}
