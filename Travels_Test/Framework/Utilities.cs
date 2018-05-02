using OpenQA.Selenium;
using System;
using System.Threading;

namespace Travels_Test.Framework
{
    public static class Utilities
    {
        public static IWebDriver Driver { get; set; }
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
        public static void TakeScreenshot(String fileName)
        {
            ITakesScreenshot screenshotHandler = Driver as ITakesScreenshot;
            Screenshot screenshot = screenshotHandler.GetScreenshot();
            screenshot.SaveAsFile(fileName + ".png", ScreenshotImageFormat.Png);
        }
    }
}