using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Travels_Test.PageObjects
{
    class Hotels
    {
        protected IWebDriver Driver { get; set; }
        public Hotels(IWebDriver driver)
        {
            Driver = driver;
        }
        #region Locators
        //public IWebElement StarGradeCheck => Driver.FindElement(By.XPath("//div[@class='col-md-3 hidden-sm hidden-xs']//*[@id='searchform']"));
        public IWebElement ApplySearch => Driver.FindElement(By.XPath("//div[@class='col-md-3 hidden-sm hidden-xs']//*[@id='searchform']"));
        #endregion

        #region Filter Search
        internal void ChangeStarGrade(string newStarGrade)
        {
            IWebElement StarGradeSelect = Driver.FindElement(By.XPath(String.Format("//div[@class='col-md-3 hidden-sm hidden-xs']//*[@for ='{0}']", newStarGrade)));
            StarGradeSelect.Click();
            ApplySearch.Click();
        }
        #endregion
    }
}
