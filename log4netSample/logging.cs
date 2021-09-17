
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.IO;
using System.Reflection;
using System;
using log4net.Config;
using log4net;
using System.Collections.Generic;

namespace log4netSample
{
    public class logging
    {
        public static ILog logger = LogManager.GetLogger(typeof(logging));
        public IWebDriver driver;

        public  void testAlertPopup()
        {
            driver = new ChromeDriver();
            var log = LogManager.GetRepository(Assembly.GetEntryAssembly());

            XmlConfigurator.Configure(log, new FileInfo("log4net.config"));

            String button_xpath = "//button[.='Click for JS Alert']";

            string url = "http://the-internet.herokuapp.com/javascript_alerts";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            driver.Url = url;
            System.Threading.Thread.Sleep(1000);

            IWebElement alertButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(button_xpath)));
            System.Threading.Thread.Sleep(1000);
            alertButton.Click();

            var alert_win = driver.SwitchTo().Alert();

            alert_win.Accept();


            var clickResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("result")));

            logger.Debug(clickResult.Text);

            if (clickResult.Text == "You successfuly clicked an alert")
            {
                logger.Info("Alert Test Successful");
                Console.WriteLine("Alert Test Successfull");
            }
            String WindowHandle1 = driver.CurrentWindowHandle;
            logger.Info("CurrentWindow ID is " + WindowHandle1);

           
        }

    }
}
