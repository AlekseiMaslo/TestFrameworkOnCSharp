using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestProject2.Base;
using TestProject2.PageObjects;

namespace TestProject2
{
    public class AutomationTests
    {
        private IWebDriver _webDriver;        

        private string _expectedLoginUserName = "Aleksei Maslo";

        [SetUp]
        public void Setup()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _webDriver.Manage().Window.Maximize();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void LoginAndPasswordTest()
        {
            var mainMenu = new MainPageObject(_webDriver);

            mainMenu
                .signIn()
                .Login(UserNameForTest.UserEmail, UserNameForTest.UserPassword);

            var actualLogin = AccountPageObject.GetUserLogin();

            Assert.AreEqual(_expectedLoginUserName, actualLogin,"Login is wrong or Enter wasn't completed");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}