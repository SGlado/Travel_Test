//using NUnit.Framework;
//using Travels_Test.Framework;
//using Travels_Test.PageObjects;

//namespace Travels_Test.Tests
//    {
//    [TestFixture]

//    class FlightSearchTests : SettingBrowsers
//        {
//        [TestCase("One way")]
//        [TestCase("Return")]
//        [TestCase("Multi city")]
//        public void FilterFlights(string WayType)
//            {
//            Driver.Navigate().GoToUrl("https://www.phptravels.net/flightst");
//            ToolbarBottom waysType = new ToolbarBottom(Driver);
//            waysType.FlightSearch(WayType);
//            }
//        }
//    }
