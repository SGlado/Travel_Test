using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class LoginLogout_Tests : BaseTest
    {
        [TestCase]
        public void Login()
        {
            var LoginPage = new ToolBarObjects(Driver);
            LoginPage.LoginForm();
            LoginPage.LoginPassAndSubmit(user);
            Assert.IsTrue((LoginPage.AccountDropdown).Displayed, "User was not logged in, wrong username or password");
        }
        [TestCase]
        public void Logout()
        {
            var LoginPage = new ToolBarObjects(Driver);
            LoginPage.Logout();
            Assert.IsTrue((LoginPage.Button_MyAccount).Displayed, "User was not logged out");
        }

    }
}
