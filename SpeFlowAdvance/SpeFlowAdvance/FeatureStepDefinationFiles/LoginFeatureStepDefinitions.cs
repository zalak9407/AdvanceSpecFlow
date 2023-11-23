using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpeFlowAdvance.Drivers;
using SpeFlowAdvance.Menu.HomeComponent;
using TechTalk.SpecFlow;

namespace SpeFlowAdvance.FeatureStepDefinationFiles
{
    [Binding]
    public class LoginFeatureStepDefinitions : MarsDriver
    {

         Login loginObj;

        // private SigninButton signinButtonObj => new SigninButton();

        public LoginFeatureStepDefinitions()
        {
            loginObj = new Login();
           // signinButtonObj = new SigninButton();


        }

        [Given(@"I click on Signin button")]
        public void GivenIClickOnSigninButton()
        {
            marsDriver = new ChromeDriver();
            // marsDriver = new ChromeDriver(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask");
            marsDriver.Manage().Window.Maximize();


            marsDriver.Navigate().GoToUrl("http://localhost:5000/");
            //  marsHook.BeforeScenarioWithTag();
            loginObj.signinTab();
        }

        [When(@"I enter valid Username and Password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            string dataJson = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceSpecFlow\AdvanceSpecFlow\SpeFlowAdvance\SpeFlowAdvance\DataFiles\LoginData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            LoginUserData user = users.users.ElementAt(0);

            //List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            //LoginUserData user = userList[0];

            loginObj.SignInAction(user.Username, user.Password);


        }

        [Then(@"I should be able to see my Username in the profile page")]
        public void ThenIShouldBeAbleToSeeMyUsernameInTheProfilePage()
        {
            string actualAccountName = loginObj.assertUsernameOnProfile();
            Assert.That(actualAccountName == "Hi zeel", "Actual Message and Expected does not match");
        }
        [When(@"I enter invalid Username and Password")]
        public void WhenIEnterInvalidUsernameAndPassword()
        {

            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[1];
            loginObj.SignInAction(user.Username, user.Password);
        }

        [Then(@"I should see the Invalid Username error message")]
        public void ThenIShouldSeeTheInvalidUsernameErrorMessage()
        {
            string actualVerificationMessage = loginObj.assertEmailErrorMessge();
            Assert.That(actualVerificationMessage == "Send Verification Email", "Actual and Expected does not match");
        }
        [When(@"I Enter null Username and Password")]
        public void WhenIEnterNullUsernameAndPassword()
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[2];
            loginObj.SignInAction(user.Username, user.Password);
        }

        [Then(@"I should see The error Message like Please enter valid email address")]
        public void ThenIShouldSeeTheErrorMessageLikePleaseEnterValidEmailAddress()
        {
            string actualEmailMessage = loginObj.assertEmailValidation();
            Assert.That(actualEmailMessage == "Please enter a valid email address", "Actual and Expected does not match");

        }
        [When(@"I Enter Invalid Username and null (.*) symbols Password")]
        public void WhenIEnterInvalidUsernameAndNullSymbolsPassword(int p0)
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[3];
            loginObj.SignInAction(user.Username, user.Password);
        }

        [Then(@"I should see The error Message like Please enter valid email address and Password must be at least (.*)character")]
        public void ThenIShouldSeeTheErrorMessageLikePleaseEnterValidEmailAddressAndPasswordMustBeAtLeastCharacter(int p0)
        {
            string actualEmailMessage = loginObj.assertEmailValidation();
            string actualPasswordMessage = loginObj.assertPasswordValidation();
            Assert.That(actualEmailMessage == "Please enter a valid email address" && actualPasswordMessage == "Password must be at least 6 characters", "Actual and Expected does not match");

        }
        [When(@"I am not entering any value in Username and Password")]
        public void WhenIAmNotEnteringAnyValueInUsernameAndPassword()
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[4];
            loginObj.SignInAction(user.Username, user.Password);
        }
        [When(@"I Enter invalid Username and without Password try to login")]
        public void WhenIEnterInvalidUsernameAndWithoutPasswordTryToLogin()
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[5];
            loginObj.SignInAction(user.Username, user.Password);
        }
        [When(@"I Enter random Username and Password")]
        public void WhenIEnterRandomUsernameAndPassword()
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[6];
            loginObj.SignInAction(user.Username, user.Password);
        }
        [When(@"I do not enter Username and enter wrong PAssword")]
        public void WhenIDoNotEnterUsernameAndEnterWrongPAssword()
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[7];
            loginObj.SignInAction(user.Username, user.Password);
        }
        [When(@"I Enter valid Username and (.*)Digit PAssword")]
        public void WhenIEnterValidUsernameAndDigitPAssword(int p0)
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[8];
            loginObj.SignInAction(user.Username, user.Password);
        }

        [Then(@"I should see The error Message like Password must be at least (.*)character")]
        public void ThenIShouldSeeTheErrorMessageLikePasswordMustBeAtLeastCharacter(int p0)
        {
            string actualPasswordMessage = loginObj.assertPasswordValidation();
            Assert.That(actualPasswordMessage == "Password must be at least 6 characters", "Actual and Expected does not match");

        }
        [When(@"I Enter Wrong Username and wrong PAssword")]
        public void WhenIEnterWrongUsernameAndWrongPAssword()
        {
            List<LoginUserData> userList = ScenarioContext.Current.Get<List<LoginUserData>>("UserList");
            LoginUserData user = userList[9];
            loginObj.SignInAction(user.Username, user.Password);
        }










    }
}

