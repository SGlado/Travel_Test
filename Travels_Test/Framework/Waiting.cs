﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Travels_Test.Framework
{
    public static class Waiting
    {
        public static bool WaitForMeDisplayed(this IWebDriver Driver, IWebElement elementToBePresent, int seconds = 30)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            try
            {
                wait.Until(p => elementToBePresent.Displayed == true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
