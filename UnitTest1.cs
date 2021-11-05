using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        #region SetUp
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            //ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.
            Driver = new ChromeDriver(); 
        }
        #endregion

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            IWebElement autoFill = Driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
            IWebElement cb1 = Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']"));
            autoFill.SendKeys("Tomato");
            cb1.Click();


            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");



            Assert.Pass();
        }
    }
}