using OpenQA.Selenium;
using System;
using Travels_Test.Framework;

namespace Travels_Test.PageObjects
{
    class ToolBarObjects
    {
        protected IWebDriver Driver { get; set; }
        public ToolBarObjects(IWebDriver driver)
        {
            Driver = driver;
        }
        #region Locators
        public IWebElement Button_MyAccount => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' My Account ']"));
        public IWebElement Button_MyAccountLogin => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' Login']"));
        public IWebElement Field_UserName => Driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        public IWebElement Field_UserPassword => Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement Button_PushLogin => Driver.FindElement(By.XPath("//*[@id='loginfrm']//button[text()='Login']"));
        public IWebElement AccountDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' DVhbCERv ']"));
        public IWebElement Button_Logout => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()='  Logout']"));
        public IWebElement CurrencyDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//li[@id='li_myaccount']/following-sibling::li[@class='dropdown']"));
        public IWebElement LanguageDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//li[@id='li_myaccount']/following-sibling::ul[@class='nav navbar-nav']"));
        #endregion
        #region ToolBar
        /// <summary>
        /// Login Form Opens
        /// </summary>
        internal void LoginForm()
        {
            Button_MyAccount.Click();
            Button_MyAccountLogin.Click();
        }
        /// <summary>
        /// Enter username and password
        /// </summary>
        internal void LoginPassAndSubmit(TestUserCredentials user)
        {
            Driver.WaitForMeDisplayed(Field_UserName, 20);
            Field_UserName.SendKeys(user.Login);
            Field_UserPassword.SendKeys(user.Password);
            Button_PushLogin.Click();
        }
        /// <summary>
        /// User Logging Out
        /// </summary>
        internal void Logout()
        {
            Driver.WaitForMeDisplayed(Button_Logout, 20);
            AccountDropdown.Click();
            Button_Logout.Click();
        }
        /// <summary>
        /// Change of Currency
        /// </summary>
        internal void ChangeCurrency(string newCurrency)
        {
            CurrencyDropdown.Click();
            Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//a[@onclick='change_currency(this)' and contains(text(), '{0}') ]", newCurrency))).Click();
        }
        /// <summary>
        /// Change of Language
        /// </summary>
        internal void ChangeLanguage(string newLanguage)
        {
            LanguageDropdown.Click();
            Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//a[@class='go-text-right changelang' and contains(text(), '{0}') ]", newLanguage))).Click();
        }
        #endregion
    }
}