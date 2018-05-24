using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
	[TestFixture]
	public class LanguageTests : SettingBrowsers
	{
		[TestCase("Arabic", "ARABIC")]
		[TestCase("Turkish", "TURKISH")]
		[TestCase("French", "FRENCH")]
		[TestCase("Spanish", "SPANISH")]
		[TestCase("Russian", "RUSSIAN")]
		[TestCase("English", "ENGLISH")]
		public void LanguageTest(string language, string expected)
		{
			var Language = new ToolBarObjects(Driver);
			Language.ChangeLanguage(language);
			Thread.Sleep(2000);
			//Driver.WaitForMeTextDisplayed(expected);
			//Utilities.TakeScreenshot(Driver, Utilities.directoryname, language);
			Assert.AreEqual(expected, Language.LanguageDropdown.Text, "Language wasn't change to preffered on " + language);
		}
	}
}
