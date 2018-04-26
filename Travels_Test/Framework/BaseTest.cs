//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System.IO;
//using System.Reflection;

//namespace Travels_Test.Framework
//{
//    public class BaseTest
//    {
//        protected IWebDriver GetChromeDriver()
//        {
//            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
//            return new ChromeDriver(outPutDirectory);
//        }
//        public IWebDriver Driver { get; set; }
//        public BaseTest(IWebDriver driver)
//        {
//            Driver = driver;
//        }
//        public BaseTest()
//        {
//        }
//    }
//}
