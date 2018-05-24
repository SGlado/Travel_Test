using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
	[TestFixture]
	public class NavigationCheck : SettingBrowsers
	{
		[TestCase("Hotels", "Hotels Listings")]
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