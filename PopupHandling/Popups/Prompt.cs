using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace PopupHandling.Popups
{
    public class Prompt
    {
        public Prompt(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsPrompt()']")]
        [CacheLookup]
        public IWebElement promptText;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement result;
    }
}
