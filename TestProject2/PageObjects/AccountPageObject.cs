using OpenQA.Selenium;

namespace TestProject2.PageObjects
{
    class AccountPageObject
    {
        private static IWebDriver _webDriver;

        private static readonly By _activeUserLoginName = By.XPath("//div[@class = 'header_user_info']//span");

        public AccountPageObject(IWebDriver webdriver)
        {
            _webDriver = webdriver;
        }

        public static string GetUserLogin()
        {
            string userLogin = _webDriver.FindElement(_activeUserLoginName).Text;
            return userLogin;
        }
    }
}