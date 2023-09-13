using NUnit.Framework;
using OpenQA.Selenium;
using SpeFlowAdvance.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpeFlowAdvance.Menu.HomeComponent
{
    public class Login : MarsHook
    {
       
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement actualAccountName => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        private IWebElement emailMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div"));
        private IWebElement passwordMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/div"));
        private IWebElement emailVerification => marsDriver.FindElement(By.CssSelector(".fluid.ui.teal.button"));
        private static IWebElement logout => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));

        public void SignInAction(string Username, string Password)
        {
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();
        }
        public string assertUsernameOnProfile()
        {
            Wait.MarsWaitToBeVisible("XPath", 20, "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");
            return actualAccountName.Text;
        }

        public string assertEmailErrorMessge()
        {
            Wait.MarsWaitToBeVisible("CssSelector", 20, ".fluid.ui.teal.button");
            return emailVerification.Text;

        }
        public string assertEmailValidation()
        {
            Wait.MarsWaitToBeVisible("XPath", 20, "/html/body/div[2]/div/div/div[1]/div/div[1]/div");
            return emailMessage.Text;
        }
        public string assertPasswordValidation()
        {
            Wait.MarsWaitToBeVisible("XPath", 20, "/html/body/div[2]/div/div/div[1]/div/div[2]/div");
            return passwordMessage.Text;
        }
        

    }
}
