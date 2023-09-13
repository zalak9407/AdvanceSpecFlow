using NUnit.Framework;
using OpenQA.Selenium;
using SpeFlowAdvance.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeFlowAdvance.Menu.DashboardComponent
{
    public class NotificationLoadMore:MarsHook
    {
        private IWebElement loadMoreButton => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a"));

        private IWebElement showLessButton => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a"));

        private IWebElement container => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div"));
        IReadOnlyCollection<IWebElement> notifications => container.FindElements(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div"));
        List<IWebElement> notificationList => notifications.SkipLast(1).ToList();

        public string pageNotifications()
        {
            int count = notificationList.Count;
            return count.ToString();

        }

       

        public void notificationSeeAll()
        {


            //Wait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div");
            //Assert.AreEqual(5, notificationList.Count, "Expected 5 notifications");

            Wait.MarsWaitToBeClickable("XPath", 20, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a");
            //*[@id="notification-section"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a
            loadMoreButton.Click();
            Wait.MarsWaitToBeVisible("XPath", 30, " //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");



        }
        public void notificationSeeless()
        {
            //Wait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div");
            //Assert.AreEqual(5, notificationList.Count, "Expected 5 notifications");

           // Wait.MarsWaitToBeClickable("XPath", 20, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a");

           // loadMoreButton.Click();
           // Wait.MarsWaitToBeVisible("XPath", 30, " //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");

            //Click on ShowLess
            Wait.MarsWaitToBeVisible("XPath", 3, " //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");
            Thread.Sleep(1000);
            showLessButton.Click();

        }

        //public void AssertForLoadMore()
        //{

        //   // Assert.AreEqual(10, notificationList.Count, "Expected 10 notifications");

        //}
        //public void AssertForSeeless()
        //{

        //    Assert.AreEqual(5, notificationList.Count, "Expected 5 notifications");

        //}
    }
}
