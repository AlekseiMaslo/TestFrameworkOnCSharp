using OpenQA.Selenium;

namespace TestProject2.PageObjects
{
    class MainPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _signInButton = By.XPath("//a[@class='login']");
        public MainPageObject(IWebDriver webdriver)
        {
            _webDriver = webdriver;
        }

        public AuthorizationPageObject signIn()
        {
            _webDriver.FindElement(_signInButton).Click();
            return new AuthorizationPageObject(_webDriver);
        }
    }
}
