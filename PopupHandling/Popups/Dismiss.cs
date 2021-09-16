﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace PopupHandling.Popups
{
    public class Dismiss
    {
        public Dismiss(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsConfirm()']")]
        [CacheLookup]
        public IWebElement dismiss;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement result;

    }
}
