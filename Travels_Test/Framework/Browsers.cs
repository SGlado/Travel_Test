using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.IO;
using System.Reflection;

namespace Travels_Test.Framework
{
    public class SettingBrowsers : Config
    {
        public static IWebDriver OpenBrowser(string browser)
        {
            string  outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (browser == "Chrome")
            {
                return new ChromeDriver(outPutDirectory);
            }
            else if (browser == "Firefox")
            {
                return new FirefoxDriver(outPutDirectory);
            }
            else if (browser == "IE")
            {
                return new InternetExplorerDriver(outPutDirectory);
            }
            else 
            {
                return new ChromeDriver(outPutDirectory);
            }
        }
        public static IWebDriver Initialize ()
        {
            GetBrowserFromFile();
            IWebDriver driver = OpenBrowser(Browser);
            return driver;
        }
    }
}