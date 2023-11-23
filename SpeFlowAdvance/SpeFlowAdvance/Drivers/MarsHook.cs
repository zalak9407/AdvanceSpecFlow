//using Newtonsoft.Json;
//using NUnit.Framework;
//using NUnit.Framework.Interfaces;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using SpeFlowAdvance.Menu.HomeComponent;
//using System.Security.Cryptography.X509Certificates;
//using TechTalk.SpecFlow;

//namespace SpeFlowAdvance.Drivers
//{
//    [Binding]
//    public class MarsHook:CommonDriver
//    {

//      // public static IWebDriver marsDriver;
//        // protected MarsBroswer marsBroswer;
//        //private LoginUserData loginUserData;
//        // private List<LoginUserData> userList;

//        // [BeforeScenario("@tag1")]
//        [SetUp]
        
//       //[BeforeScenario]
//       // [BeforeScenario(Order = 0)]
//        public void BeforeScenarioWithTag()
//        {
//            MarsExtentReporting.MarsExtentReportingCreateTest(TestContext.CurrentContext.Test.MethodName);
//            // marsDriver = new ChromeDriver(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask");
//            // if (marsDriver == null)
//            //{ IWebDriver marsDriver;
//            //IWebDriver marsDriver;
//            marsDriver = new ChromeDriver();
//                marsDriver.Manage().Window.Maximize();
//                marsDriver.Navigate().GoToUrl("http://localhost:5000/");
//                Thread.Sleep(5000);
//           // }
//           // marsBroswer = new MarsBroswer(marsDriver);

//        }

//       // [BeforeScenario(Order = 1)]
//        [BeforeScenario]
//        public void FirstBeforeScenario(ScenarioContext scenarioContext)
//        {
//            string jsonPath = "C:\\Users\\jeelp\\OneDrive\\Desktop\\AdvanceSpecFlow\\AdvanceSpecFlow\\SpeFlowAdvance\\SpeFlowAdvance\\DataFiles\\LoginData.json";
//            string jsonData = File.ReadAllText(jsonPath);
//            List<LoginUserData> userList = JsonConvert.DeserializeObject<List<LoginUserData>>(jsonData);
//            scenarioContext["UserList"] = userList;
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            MarsDriverEndTest();
//            MarsExtentReporting.MarsExtentReportingEndReporting();
//            marsDriver.Quit();
//           // marsDriver = null;
//        }

//        private void MarsDriverEndTest()
//        {
//            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
//            var message = TestContext.CurrentContext.Result.Message;

//            switch (testStatus)
//            {
//                case TestStatus.Failed:
//                    MarsExtentReporting.MarsExtentReportingLogFail($"Test has failed {message}");
//                    break;
//                case TestStatus.Skipped:
//                    MarsExtentReporting.MarsExtentReportingLogInfo($"Test skipped {message}");
//                    break;
//                default:
//                    break;
//            }

//         //   MarsExtentReporting.MarsExtentReportingLogScreenShot("Ending test", marsBroswer.MarsBroswerGetScreenShot());
//        }
//    }
//}