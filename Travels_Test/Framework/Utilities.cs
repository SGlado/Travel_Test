using OpenQA.Selenium;
using System;
using System.Threading;

namespace Travels_Test.Framework
    {
    public class Utilities
        {
        public static IWebDriver Driver { get; set; }
        #region Highlight Element
        public static void HighlighElement(IWebDriver driver, IWebElement element)
            {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.border='4px solid red'", element);
            try
                {
                Thread.Sleep(500);
                }
            catch
                {
                }
            }
        #endregion
        #region Screenshot
        public static void TakeScreenshot(String fileName)
            {
            ITakesScreenshot screenshotHandler = Driver as ITakesScreenshot;
            Screenshot screenshot = screenshotHandler.GetScreenshot();
            screenshot.SaveAsFile(@"D:\HELP\AUTOMATION\SGlado\Travels_Test\FailureScreenshots\" + fileName + ".png", ScreenshotImageFormat.Png);
            }
        #endregion
        }
    }