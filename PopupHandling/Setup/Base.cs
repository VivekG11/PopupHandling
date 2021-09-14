using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PopupHandling
{
    public class BaseClass
    {
        public string url = "http://the-internet.herokuapp.com/javascript_alerts";
        public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start-Maximized");
            options.AddArgument("--disable-notification");
            options.AddArgument("--headless");

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(200);
        }
/*
        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
*/
    }
}