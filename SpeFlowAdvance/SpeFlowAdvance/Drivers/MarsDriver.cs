//using NUnit.Framework.Interfaces;
//using NUnit.Framework;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Chrome;

//namespace SpeFlowAdvance.Drivers
//{
//    public class MarsDriver
//    {
       

//            public static IWebDriver marsDriver;
           
//            protected MarsBroswer marsBroswer;


//            [SetUp]
//            public void MarsDriverStartWebsite()
//            {
//                MarsExtentReporting.MarsExtentReportingCreateTest(TestContext.CurrentContext.Test.MethodName);
//               // marsDriver = new EdgeDriver();
//                //marsDriver = new ChromeDriver();
//                 marsDriver = new ChromeDriver(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask");
//                marsDriver.Manage().Window.Maximize();


//                marsDriver.Navigate().GoToUrl("http://localhost:5000/");
//                Thread.Sleep(5000);
//                marsBroswer = new MarsBroswer(marsDriver);
//            }


//            [TearDown]
//            public void MarsDriverCloseBrowser()
//            {
//                MarsDriverEndTest();
//                MarsExtentReporting.MarsExtentReportingEndReporting();
//                marsDriver.Quit();
//            }

//            private void MarsDriverEndTest()
//            {
//                var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
//                var message = TestContext.CurrentContext.Result.Message;

//                switch (testStatus)
//                {
//                    case TestStatus.Failed:
//                        MarsExtentReporting.MarsExtentReportingLogFail($"Test has failed {message}");
//                        break;
//                    case TestStatus.Skipped:
//                        MarsExtentReporting.MarsExtentReportingLogInfo($"Test skipped {message}");
//                        break;
//                    default:
//                        break;
//                }

//                MarsExtentReporting.MarsExtentReportingLogScreenShot("Ending test", marsBroswer.MarsBroswerGetScreenShot());
//            }
//        }
//    }

