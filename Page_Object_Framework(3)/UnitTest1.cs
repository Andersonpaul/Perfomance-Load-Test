﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using SoftwareTesting;
using NUnit.Framework;
using Home_Page;


namespace Page_Object_Framework_3_
{
    [TestFixture]
    public class UnitTest1
    {
        RemoteWebDriver driver;
        IAlert alert;
        string url;
        [TestFixtureSetUp]
        public void setup()
        {
           
            DesiredCapabilities cap = DesiredCapabilities.Firefox();
            cap.SetCapability(cap.BrowserName, "firefox");   
            driver = new RemoteWebDriver(cap);            
            url = "http://62.173.32.45/cipgharmonized/";
        }
        [Test,Timeout(500000)]
        public void TestMethod1()
        {
          
            driver.Navigate().GoToUrl(url);
            Reusables obj = new Reusables(driver);            
            obj.test();            
            alert = driver.SwitchTo().Alert();
            alert.Accept();                            
        }
      
        [Test,Timeout(500000)]
        public void TestMethod2()
        {
            Reusables1 obj1 = new Reusables1(driver);           
            obj1.reusables1();            
        }
        
    }
}
