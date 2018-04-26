using NUnit.Framework;
using System.Threading;
using Travels_Test.Framework;
using Travels_Test.PageObjects;
using OpenQA.Selenium;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class NavigationCheck : SettingBrowsers
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
        [TestCase ("Hotels", "Hotels Listings")]
        [TestCase("Travelstart", "Flights")]
        [TestCase("Tours", "Tours Listings")]
        [TestCase("Cars", "Car Rentals")]
        [TestCase("Offers", "Special Offers")]
        [TestCase("Ivisa", "Ivisa")]
        [TestCase("Blog", "Blog")]

        public void NavigationCheckAll(string page, string pageTitle)
        {
            var NavigationChecking = new ToolbarBottom(Driver);
            NavigationChecking.NavigationCheck(page, pageTitle);
            Assert.AreEqual(pageTitle, Driver.Title, "Ooops! Page was not loaded");
        }
    }
}