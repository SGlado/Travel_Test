using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class LoginLogout_Tests : BaseTest
    {
        #region Setup
        [OneTimeSetUp]
        public void Init()
        {
            Driver = GetChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.phptravels.net/");
            user = new TestUserCredentials();
            user.Login = "user@phptravels.com";
            user.Password = "demouser";
        }
        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
        #endregion
        [TestCase]
        public void Login()
        {
            var LoginPage = new ToolBarObjects(Driver);
            LoginPage.LoginForm();
            LoginPage.LoginPassAndSubmit(user);
            Assert.IsTrue((LoginPage.AccountDropdown).Displayed, "User was not logged in, wrong username or password");
            LoginPage.Logout();
            Assert.IsTrue((LoginPage.Button_MyAccount).Displayed, "User was not logged out");
        }
    }
}
