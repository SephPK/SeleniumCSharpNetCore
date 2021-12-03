using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage : DriverHelper
    {
        public void ClickLogin()
        {
            IWebElement btnLogin = Driver.FindElement(By.Id("loginLink"));
            btnLogin.Click();
        }
        public bool IsLogOffExist()
        {
            IWebElement btnLogoff = Driver.FindElement(By.LinkText("Log off"));
            return btnLogoff.Displayed;
        }
    }
}
