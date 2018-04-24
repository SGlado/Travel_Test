using NUnit.Framework;
using OpenQA.Selenium;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    class FilterSearch_StarGradeTests : BaseTest
    {
        #region Setup
        [OneTimeSetUp]
        public void Init()
        {
            Driver = GetChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.phptravels.net/hotels");
        }
        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
        #endregion
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        [TestCase("4")]
        [TestCase("5")]
        public void StarGrade(string starGradeNumber)
        {
            Hotels starGrade = new Hotels(Driver);
            starGrade.ChangeStarGradeNumber(starGradeNumber);
            Driver.WaitForMeDisplayed(starGrade.ApplySearch, 20);
            IWebElement StarGradeCheck = starGrade.StarGradeCheckNumber(starGradeNumber);
            Assert.IsTrue(StarGradeCheck.Selected, "Ooops!");
        }
    }
}
