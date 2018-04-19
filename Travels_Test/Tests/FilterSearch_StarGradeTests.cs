using NUnit.Framework;
using OpenQA.Selenium;
using System;
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
        public void StarGrade(string starGrade)
        {
            var StarGrade = new Hotels(Driver);
            StarGrade.ChangeStarGrade(starGrade);
            Driver.WaitForMeDisplayed(StarGrade.ApplySearch, 20);
            IWebElement StarGradeCheck = Driver.FindElement(By.XPath(String.Format("//div[@class='col-md-3 hidden-sm hidden-xs']//input[@id ='{0}']", starGrade)));
            Assert.IsTrue(StarGradeCheck.Selected, "oh!");
        }
    }
}
