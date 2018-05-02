//using OpenQA.Selenium;
//using NUnit.Framework;
//using Travels_Test.Framework;
//using NUnit.Framework.Internal;

//namespace Travels_Test.Tests
//{
//    [TestFixture]
//    public class Highligh : SettingBrowsers
//    {
//        public IWebElement Button_MyAccount => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' My Account ']"));
//        [TestCase]
//        public void HighlighTest(IWebElement element)
//        {
//            Utilities.HighlighElement(Driver, Button_MyAccount);
//        }
//    }
//}



////    //public static void HighlighElement(this IWebDriver driver, IWebElement element)
////    //{
////    //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

////    //    js.ExecuteScript("arguments[0].style.border='3px solid red'", element);


////    //}
////    //[TestFixture]
////    //public class Highlighting : SettingBrowsers
////    //{
////    //    private IWebElement Button_MyAccount;

////    //    [TestCase]
////    //    public void checkHotelsPage()
////    //    {
////    //        Driver.Highlight(Button_MyAccount);

////    //        Driver.Navigate().GoToUrl("https://www.phptravels.net/hotels");
////    //        Driver.FindElement(By.XPath("//a[@title='Hotels']"));

////    //    }
////    //}
////}