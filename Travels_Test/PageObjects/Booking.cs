using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Travels_Test.Framework;

namespace Travels_Test.PageObjects
{
	class Booking : SettingBrowsers
	{
		public Booking(IWebDriver driver)
		{
			Driver = driver;
		}
		#region Locators
		public IWebElement PageHotels => Driver.FindElement(By.XPath("//a[@title='Hotels']"));
		public IWebElement Button_OpenHotelDetails => Driver.FindElement(By.XPath("//*[b='Rendezvous Hotels                  ']"));
		public IWebElement Button_BookRoom => Driver.FindElement(By.XPath("//*[text()='Book Now']"));
		public IWebElement Button_BookAsAGuest => Driver.FindElement(By.XPath("//*[text()='Book as a Guest']"));
		public IWebElement Field_FirstName => Driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
		public IWebElement Field_Email => Driver.FindElement(By.XPath("//input[@placeholder='Email']"));
		public IWebElement Field_MobileNumber => Driver.FindElement(By.XPath("//input[@placeholder='Contact Number']"));
		public IWebElement Field_Country => Driver.FindElement(By.XPath("//*[@class='select2-chosen']"));
		public IWebElement Field_TypeCountry => Driver.FindElement(By.XPath("//div[@class='select2-search']/input"));
		public IWebElement Field_SubmitCountry => Driver.FindElement(By.XPath("//*[text()=' Minor Outlying Islands']"));
		public IWebElement Field_LastName => Driver.FindElement(By.XPath("//*[@placeholder='Last Name']"));
		public IWebElement Field_ConfirmEmail => Driver.FindElement(By.XPath("//input[@placeholder='Confirm Email']"));
		public IWebElement Field_Address => Driver.FindElement(By.XPath("//input[@placeholder='Address']"));
		public IWebElement Button_Confirm_Booking => Driver.FindElement(By.XPath("//*[@class='btn btn-action btn-lg btn-block completebook']"));
		public IWebElement Button_PayOnArrival => Driver.FindElement(By.XPath("//*[@class='btn btn-default arrivalpay']"));
		#endregion

		#region Booking Room
		/// <summary>
		/// Booking room as a guest
		/// </summary>
		public void BookAnyRoom()
		{
			PageHotels.Click();
			Button_OpenHotelDetails.Click();
			Actions actions = new Actions(Driver);
			actions.MoveToElement(Button_BookRoom);
			actions.Perform();
			Button_BookRoom.Click();
			Button_BookAsAGuest.Click();
		}
		/// <summary>
		/// Fill booking fors and submit
		/// </summary>
		public void GuestFormAndSubmit()
		{
			Field_FirstName.SendKeys("TestFirstName");
			Field_Email.SendKeys("TestEmail@mail.com");
			Field_MobileNumber.SendKeys("1234567890");
			Field_LastName.SendKeys("TestLastName");
			Field_ConfirmEmail.SendKeys("TestEmail@mail.com");
			Field_Address.SendKeys("TestAddress");
			Field_Country.Click();
			Field_TypeCountry.SendKeys("United States");
			Field_SubmitCountry.Click();
			Actions actions = new Actions(Driver);
			actions.MoveToElement(Button_Confirm_Booking);
			actions.Perform();
			Button_Confirm_Booking.Click();
		}
		#endregion
	}
}