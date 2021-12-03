using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement txtUserName = Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword = Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin = Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void EnterUsernameAndPass(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }

    }
}
