using System;
using System.Collections.Generic;
using System.Text;
using PopupHandling.Popups;

namespace PopupHandling.Functions
{
    public class Action:BaseClass
    {
        public static void Alertpopup()
        {
            Alert alert = new Alert(driver);
            alert.alertButton.Click();
            System.Threading.Thread.Sleep(1000);


            var alert_field = driver.SwitchTo().Alert();
            alert_field.Accept();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine(alert.result.Text);
            System.Threading.Thread.Sleep(1000);
            if(alert.result.Text == "You successfuly clicked an alert")
            {
                Console.WriteLine("Alert Test Successful");
            }

        }

        public static void confirmpopup()
        {
            Confirm confirm = new Confirm(driver);
            confirm.confirm.Click();
            System.Threading.Thread.Sleep(1000);


            var confirm_field = driver.SwitchTo().Alert();
            confirm_field.Accept();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine(confirm.result.Text);
            System.Threading.Thread.Sleep(1000);
            if (confirm.result.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successful");
            }

        }

        public static void dismisspopup()
        {
            Dismiss dismiss = new Dismiss(driver);
            dismiss.dismiss.Click();
            System.Threading.Thread.Sleep(1000);


            var dismiss_field = driver.SwitchTo().Alert();
            dismiss_field.Dismiss();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine(dismiss.result.Text);
            System.Threading.Thread.Sleep(1000);
            if (dismiss.result.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }

        }

        public static void Promptpopup()
        {
            Prompt prompt = new Prompt(driver);
            prompt.promptText.Click();
            System.Threading.Thread.Sleep(1000);

            var prompt_field = driver.SwitchTo().Alert();
            prompt_field.Accept();

            Console.WriteLine(prompt.result.Text);
            System.Threading.Thread.Sleep(1000);
            if (prompt.result.Text == "You entered: This is a test alert message") ;
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
        }
    }
}
