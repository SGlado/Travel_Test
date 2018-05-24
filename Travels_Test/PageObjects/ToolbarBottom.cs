using OpenQA.Selenium;
using System;

namespace Travels_Test.PageObjects
{
	class ToolbarBottom
	{
		protected IWebDriver Driver { get; set; }
		public ToolbarBottom(IWebDriver driver)
		{
			Driver = driver;
		}
		#region Locators
		public IWebElement ApplySearch => Driver.FindElement(By.XPath("//*[@id='searchform']"));
		public IWebElement SelectStarGradeNumber;
		#endregion

		#region Hotels Stats Filter Search
		/// <summary>
		/// Filter --> Filter by Hotel Star Count
		/// </summary>
		/// <param name="newStarGradeNumber"></param>
		public void ChangeStarGradeNumber(string newStarGradeNumber)
		{
			SelectStarGradeNumber = Driver.FindElement(By.XPath(String.Format("//div[@class='col-md-3 hidden-sm hidden-xs']//*[@for ='{0}']", newStarGradeNumber)));
			StarGradeCheckNumber(newStarGradeNumber);
			SelectStarGradeNumber.Click();
			ApplySearch.Click();
		}
		public IWebElement StarGradeCheckNumber(string checkStarGradeNumber)
		{
			return Driver.FindElement(By.XPath(String.Format("//div[@class='col-md-3 hidden-sm hidden-xs']//input[@id ='{0}']", checkStarGradeNumber)));
		}
		#endregion
		#region NavigationCheck
		/// <summary>
		/// Verify Navigation on ToolbarBottom
		/// </summary>
		/// <param name="newPage"></param>
		internal void NavigationCheck(string newPage, string newPageTitle)
		{
			Driver.FindElement(By.XPath(String.Format("//a[@title='{0}']", newPage))).Click();
		}
		#endregion
		//#region FlightSearch
		//internal void FlightSearch(string newWayType)
		//    {
		//    Driver.FindElement(By.XPath(String.Format("//*[@class='ng-scope' and contains(text(), '{0}')]", newWayType))).Click();
		//    }
		//#endregion
	}
}
