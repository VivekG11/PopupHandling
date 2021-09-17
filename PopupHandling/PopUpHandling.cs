using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using log4net;
using System.Collections.Generic;

namespace PopupHandling
{
   public class PopUpHandling : BaseClass
    {
       [Test]
       public void TestAlertPopup()
        {
            Functions.Action.Alertpopup();
        }

        [Test]
        public void TestConfirmPopup()
        {
            Functions.Action.confirmpopup();
        }

        [Test]
        public void TestDismissPopup()
        {
            Functions.Action.dismisspopup();
        }

        [Test]
        public void TestPromptPopup()
        {
            Functions.Action.Promptpopup();
        }
    }
}
