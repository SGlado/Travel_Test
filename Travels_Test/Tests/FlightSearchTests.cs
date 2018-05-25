using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
	[TestFixture]
	public class FlightSearchTests : SettingBrowsers
	{
		[TestCase("One way")]
		[TestCase("Return")]
		[TestCase("Multi city")]
		public void FilterFlights(string wayType)
		{
			var WaysType = new ToolbarBottom(Driver);
			Driver.Navigate().GoToUrl("https://www.phptravels.net/flightst");
			WaysType.FlightSearch(wayType);
		}
	}
}
