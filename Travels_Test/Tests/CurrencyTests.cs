using NUnit.Framework;
using System.Threading;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
	[TestFixture]
	public class CurrencyTests : SettingBrowsers
	{
		[TestCase("USD", "USD")]
		[TestCase("GBP", "GBP")]
		[TestCase("SAR", "ريال")]
		[TestCase("EUR", "EUR")]
		[TestCase("JPY", "JPY")]
		[TestCase("INR", "INR")]
		[TestCase("CNY", "CNY")]
		[TestCase("TRY", "TURKISH")]
		public void CurrencyTest(string currency, string expected)
		{
			var Currency = new ToolBarObjects(Driver);
			Currency.ChangeCurrency(currency);
			Driver.WaitForMeTextDisplayed(Currency.CurrencyDropdown, expected);
			Assert.AreEqual(expected, Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on " + currency);
		}
	}
}