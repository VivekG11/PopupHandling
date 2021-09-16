using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace PopupHandling.Popups
{
    public class Alert
    {
        public Alert(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[.='Click for JS Alert']")]
        [CacheLookup]
        public IWebElement alertButton;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement result;
    }
}
