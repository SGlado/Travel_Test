using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Travels_Test.Framework
{
    public class BaseTest
    {
        internal TestUserCredentials user { get; set; }
        protected IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
        public IWebDriver Driver { get; set; }
        public BaseTest(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(10);
        }
        public BaseTest()
        {
        }
        [OneTimeSetUp]
        public void SetupEverySingleClass()
        {
            Driver = GetChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.phptravels.net/");
            user = new TestUserCredentials();
            user.Login = "user@phptravels.com";
            user.Password = "demouser";
        }
        [OneTimeTearDown]
        public void CleanupEverySinglClass()
        {
            Driver.Quit();
        }

    }
}
