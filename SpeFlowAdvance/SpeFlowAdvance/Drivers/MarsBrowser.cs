//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SpeFlowAdvance.Drivers
//{
//    public class MarsBroswer : MarsHook
//    {
//      //  private IWebDriver marsDriver;

//        //public MarsBroswer(IWebDriver marsDriver)
//        //{
//        //    this.marsDriver = marsDriver;
//        //}

//        public string MarsBroswerGetScreenShot()
//        {
//            Thread.Sleep(200);
//            var file = ((ITakesScreenshot)marsDriver).GetScreenshot();
//            var img = file.AsBase64EncodedString;

//            return img;
//        }

//        public static implicit operator MarsBroswer(ChromeDriver v)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
