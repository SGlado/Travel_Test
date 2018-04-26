using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class LanguageTests : SettingBrowsers
    {
        #region Setup
        [OneTimeSetUp]
        public void CreateDriver()
        {
            Driver = SettingBrowsers.Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.phptravels.net/");
        }
        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
        #endregion
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
                Driver.WaitForMeDisplayed(Language.LanguageDropdown, 20);
                Assert.AreEqual(expected, Language.LanguageDropdown.Text, "Language wasn't change to preffered on " + language);
            }
        }
    }
