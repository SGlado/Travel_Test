using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class LoginLogout_Tests : SettingBrowsers
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
        [TestCase]
        public void LoginLogout()
        {
            var LoginPage = new ToolBarObjects(Driver);
            LoginPage.LoginForm();
            LoginPage.LoginPassAndSubmit();
            LoginPage.Logout();
            Driver.WaitForMeDisplayed(LoginPage.Button_MyAccount, 20);
            Assert.IsTrue(LoginPage.Button_MyAccount.Displayed, "User was not logged out");
        }
    }
}
