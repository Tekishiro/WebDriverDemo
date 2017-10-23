using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void oneCanOpenGoogle()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://github.com/login");

            IWebElement inputLogin = chrome.FindElement(By.XPath("//input[@id='login_field']"));
            inputLogin.SendKeys("testautomationuser");

            IWebElement inputPassword = chrome.FindElement(By.XPath("//input[@id='password']"));
            inputPassword.SendKeys("Time4Death!");

            IWebElement loginButton = chrome.FindElement(By.XPath("//input[@type='submit']"));
            loginButton.Click();
        }
    }
}
