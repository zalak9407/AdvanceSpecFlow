using NUnit.Framework;
using OpenQA.Selenium;
using SpeFlowAdvance.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeFlowAdvance.Menu.ManageRequestComponents
{
    public class ManageRequestReceiveAccept:MarsDriver
    {
       
        private IWebElement acceptReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]"));
        private IWebElement checkStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement actualStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));

        public void receiveReqAccept()
        {
            //accept request
            Thread.Sleep(1000);
            if (checkStatus.Text == "Pending")
            {
                Wait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[2]/td[8]/button[1]");

                acceptReqTab.Click();

                Thread.Sleep(1000);
               // Assert.That(actualStatus.Text == "Accepted", "Actual result and expected result so not match");
            }
            else
            {
                Console.WriteLine("There is no pending request");
            }

        }
        public string assertAcceptedRequest()
        {
            Wait.MarsWaitToBeVisible("XPath", 20, "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]");
            return actualStatus.Text;
        }
    }
}
