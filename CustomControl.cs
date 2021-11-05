using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboBox = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboBox.Clear();
            comboBox.SendKeys(value);
            Driver.FindElement(By.XPath($"//input[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();

        }
    }
}
