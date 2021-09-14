using OpenQA.Selenium;
using System.Threading;

namespace TestProject2.PageObjects
{
    class AuthorizationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _emailField = By.Id("email");
        private readonly By _passwordField = By.Id("passwd");
        private readonly By _submitLoginButton = By.Id("SubmitLogin");



        public AuthorizationPageObject(IWebDriver webdriver)
        {
            _webDriver = webdriver;
        }

        public AccountPageObject Login(string email, string password)
        {
            _webDriver.FindElement(_emailField).SendKeys(email);
            _webDriver.FindElement(_passwordField).SendKeys(password);
            _webDriver.FindElement(_submitLoginButton).Click();
            return new AccountPageObject(_webDriver);
        }
    }
}
