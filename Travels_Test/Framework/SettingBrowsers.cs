using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.IO;
using System.Reflection;

namespace Travels_Test.Framework
{
	public class SettingBrowsers
	{
		#region Browser
		/// <summary>
		/// Select appropriate browser from config file
		/// </summary>
		/// <param name="browser"></param>
		/// <returns></returns>
		public static IWebDriver OpenBrowser(string browser)
		{
			string outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
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
		public IWebDriver Driver;
		public IWebDriver Initialize()
		{
			IWebDriver driver = OpenBrowser(Config.Instance.Browser);
			return driver;
		}
		#endregion
		[OneTimeSetUp]
		public void CreateDriver()
		{
			Driver = Initialize();
			Driver.Manage().Window.Maximize();
			Driver.Navigate().GoToUrl("https://www.phptravels.net/");
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
		}
		[OneTimeTearDown]
		public void Cleanup()
		{
			Driver.Quit();
		}
	}
}