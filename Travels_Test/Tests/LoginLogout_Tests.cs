using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
	[TestFixture]
	public class LoginLogout_Tests : SettingBrowsers
	{
		[TestCase]
		public void LoginLogout()
		{
			var LoginPage = new ToolBarObjects(Driver);
			LoginPage.LoginForm();
			LoginPage.LoginPassAndSubmit();
			LoginPage.Logout();
			Assert.IsTrue(LoginPage.Button_MyAccount.Displayed, "User was not logged out");
		}
	}
}
