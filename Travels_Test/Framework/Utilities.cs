using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace Travels_Test.Framework
    {
    public class Utilities
        {
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
        public static void TakeScreenshot(IWebDriver driver, String fileName, String directoryName)
            {
            ITakesScreenshot screenshotHandler = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotHandler.GetScreenshot();
            string filename = fileName + DateTime.Now.ToString(" - dd_MMMM_hh_mm_ss_tt") + ".png";
            string newfolder = Directory.CreateDirectory(Path.Combine(@"D:\HELP\AUTOMATION\SGlado\Travels_Test\FailureScreenshots\", directoryName)).FullName.ToString() ;
            
            string fullPath = Path.Combine(newfolder, filename);
            screenshot.SaveAsFile(fullPath);
            }
        #endregion
        }
    }