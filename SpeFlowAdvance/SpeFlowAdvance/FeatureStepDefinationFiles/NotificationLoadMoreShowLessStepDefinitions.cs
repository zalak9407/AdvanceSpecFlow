using NUnit.Framework;
using SpeFlowAdvance.Drivers;
using SpeFlowAdvance.Menu.DashboardComponent;
using SpeFlowAdvance.Menu.HomeComponent;
using System;
using TechTalk.SpecFlow;

namespace SpeFlowAdvance.FeatureStepDefinationFiles
{
    [Binding]
    public class NotificationLoadMoreShowLessStepDefinitions:MarsHook
    {
      private  Login loginObj = new Login();
      private SigninButton signinButtonObj=  new SigninButton();
      private  DashboardButton dashboardButtonObj = new DashboardButton();
      private  NotificationLoadMore notificationObj =new NotificationLoadMore();
        //public NotificationLoadMoreShowLessStepDefinitions() 
        //{
        //    loginObj = new Login();
        //    signinButtonObj = new SigninButton();
        //    dashboardButtonObj = new DashboardButton();
        //    notificationObj = new NotificationLoadMore();
        //}
        [Given(@"I logged into mars with valid credential")]
        public void GivenILoggedIntoMarsWithValidCredential()
        {
            signinButtonObj.signinTab();
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[0];
            loginObj.SignInAction(user.Username, user.Password);
        }

        [Given(@"I click on DashBoard and See Five Notifications")]
        public void GivenIClickOnDashBoardAndSeeFiveNotifications()
        {
           dashboardButtonObj.dashboardTab();
            string actualCount = notificationObj.pageNotifications();
            Assert.AreEqual(5, actualCount , "Expected 5 notifications");
        }

        [When(@"I click on LoadMore Button")]
        public void WhenIClickOnLoadMoreButton()
        {
            notificationObj.notificationSeeAll();
        }

        [When(@"I Should able to see Ten Notifications")]
        public void WhenIShouldAbleToSeeTenNotifications()
        {
            string actualCount = notificationObj.pageNotifications();
            Assert.AreEqual(10, actualCount, "Expected 10 notifications");
        }

        [When(@"I click on ShowLess Button")]
        public void WhenIClickOnShowLessButton()
        {
            notificationObj.notificationSeeless();
        }

        [Then(@"I should able to see Five Notifications")]
        public void ThenIShouldAbleToSeeFiveNotifications()
        {
            string actualCount = notificationObj.pageNotifications();
            Assert.AreEqual(5, actualCount, "Expected 5 notifications");
        }
    }
}
