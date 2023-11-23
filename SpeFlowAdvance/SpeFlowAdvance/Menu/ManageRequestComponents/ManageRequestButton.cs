using OpenQA.Selenium;
using SpeFlowAdvance.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeFlowAdvance.Menu.ManageRequestComponents
{
    public class ManageRequestButton:MarsDriver
    {
        private IWebElement receivedReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]"));
        private IWebElement manageReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]"));
        public void manageRequestTab()
        {
            Wait.MarsWaitToBeClickable("XPath", 10, " //*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]");

            manageReqTab.Click();

            Wait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]");

            receivedReqTab.Click();
        }
    }
}
