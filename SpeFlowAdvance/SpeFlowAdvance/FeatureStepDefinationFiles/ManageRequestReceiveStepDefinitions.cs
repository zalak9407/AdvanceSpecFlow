using NUnit.Framework;
using SpeFlowAdvance.Drivers;
using SpeFlowAdvance.Menu.HomeComponent;
using SpeFlowAdvance.Menu.ManageRequestComponents;
using System;
using TechTalk.SpecFlow;

namespace SpeFlowAdvance.FeatureStepDefinationFiles
{
    //[Binding]
    public class ManageRequestReceiveStepDefinitions : MarsHook
    {
        Login loginObj;
        SigninButton signinButtonObj;
        ManageRequestButton requestButtonObj;
        ManageRequestReceiveAccept acceptObj;
        public ManageRequestReceiveStepDefinitions()
        {
            loginObj = new Login();
            signinButtonObj = new SigninButton();
            requestButtonObj = new ManageRequestButton();
            acceptObj = new ManageRequestReceiveAccept();
        }
        [Given(@"I logged into mars using valid credential")]
        public void GivenILoggedIntoMarsUsingValidCredential()
        {
            signinButtonObj.signinTab();
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[0];
            loginObj.SignInAction(user.Username, user.Password);
        }

        [When(@"I clicked on manageRequests and choose\(click\) on receive requests")]
        public void WhenIClickedOnManageRequestsAndChooseClickOnReceiveRequests()
        {
            requestButtonObj.manageRequestTab();

        }

        [When(@"I check the status of the request if it is pending i click on Accept")]
        public void WhenICheckTheStatusOfTheRequestIfItIsPendingIClickOnAccept()
        {
            acceptObj.receiveReqAccept();
        }

        [Then(@"I should able to see request has been accepted")]
        public void ThenIShouldAbleToSeeRequestHasBeenAccepted()
        {
            // if (!Pending)
            {
                string actualStatus = acceptObj.assertAcceptedRequest();
                Assert.That(actualStatus == "Accepted", "Actual result and expected result so not match");
            }
        }

        [When(@"I check the status of the request if it is pending i click on Decline")]
        public void WhenICheckTheStatusOfTheRequestIfItIsPendingIClickOnDecline()
        {
            throw new PendingStepException();
        }

        [Then(@"I should able to see request has been Declined")]
        public void ThenIShouldAbleToSeeRequestHasBeenDeclined()
        {
            throw new PendingStepException();
        }
    }
}
