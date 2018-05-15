using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
    {
    [TestFixture]
    public class BookingRoom : SettingBrowsers
        {
        [TestCase]
        public void BookingAnyRoom()
            {
            var BookingAnyRoom = new Booking(Driver);
            BookingAnyRoom.BookAnyRoom();
            Assert.IsTrue(BookingAnyRoom.Field_FirstName.Displayed, "Ooops! Page was not loaded");
            BookingAnyRoom.GuestFormAndSubmit();
            Assert.IsTrue(BookingAnyRoom.Button_PayOnArrival.Displayed, "Ooops! Page was not loaded");
            }
        }
    }