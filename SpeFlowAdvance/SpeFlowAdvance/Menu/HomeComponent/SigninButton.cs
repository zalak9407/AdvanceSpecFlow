using OpenQA.Selenium;
using SpeFlowAdvance.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeFlowAdvance.Menu.HomeComponent
{
    public class SigninButton : MarsHook
    {
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));

        public void signinTab()
        {
            signInButton.Click();
        }

    }

}
