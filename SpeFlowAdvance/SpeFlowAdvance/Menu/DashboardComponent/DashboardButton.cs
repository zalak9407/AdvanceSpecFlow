using OpenQA.Selenium;
using SpeFlowAdvance.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeFlowAdvance.Menu.DashboardComponent
{
    public class DashboardButton:MarsHook
    {
        private IWebElement dashboardButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]"));
        public void dashboardTab()
        {
            //Go to Dashboard
            Wait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]");
            dashboardButton.Click();
        }
    }
}
