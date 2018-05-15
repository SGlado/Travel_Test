using NUnit.Framework;
using OpenQA.Selenium;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
    {
    [TestFixture]
    class FilterSearch_StarGradeTests : SettingBrowsers
        {
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        [TestCase("4")]
        [TestCase("5")]
        public void StarGrade(string starGradeNumber)
            {
            Driver.Navigate().GoToUrl("https://www.phptravels.net/hotels");
            ToolbarBottom starGrade = new ToolbarBottom(Driver);
            starGrade.ChangeStarGradeNumber(starGradeNumber);
            IWebElement StarGradeCheck = starGrade.StarGradeCheckNumber(starGradeNumber);
            Assert.IsTrue(StarGradeCheck.Selected, "Ooops!");
            }
        }
    }
