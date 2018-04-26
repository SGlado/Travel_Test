using OpenQA.Selenium;
using System;
using System.Threading;
using Travels_Test.Framework;

namespace Travels_Test.PageObjects
{
    class ToolBarObjects : Config
    {
        //protected IWebDriver Driver { get; set; }
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
        public IWebElement AccountDropdown;
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
        internal void LoginPassAndSubmit()
        {
            Config.GetLoginFromFile();
            string lg = Login;
            string ps = Config.Pass;
            Driver.WaitForMeDisplayed(Field_UserName, 20);
            Field_UserName.SendKeys(lg);
            Field_UserPassword.SendKeys(ps);
            Driver.WaitForMeDisplayed(Button_PushLogin, 20);
            Button_PushLogin.Click();
        }
        /// <summary>
        /// User Logging Out
        /// </summary>
        internal void Logout()
        {
            Config.GetLoginFromFile();
            string un = Config.Username;
            Thread.Sleep(3000);
            AccountDropdown = Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()='{0}']", un)));
            AccountDropdown.Click();
            Button_Logout.Click();
            Thread.Sleep(3000);
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