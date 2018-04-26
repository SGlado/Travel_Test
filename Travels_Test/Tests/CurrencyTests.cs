using NUnit.Framework;
using System.Threading;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class CurrencyTests : SettingBrowsers
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
                //Driver.WaitForMeDisplayed(Currency.CurrencyDropdown, 10);
                Thread.Sleep(5000);
                Assert.AreEqual(expected, Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on " + currency);
            }
    }
}