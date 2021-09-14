using OpenQA.Selenium;

namespace TestProject2.Base
{
    class UserNameForTest
    {
        private IWebDriver _webDriver;

        private static string _userEmail = "alekseimaslo+1@gmail.com";
        private static string _userPassword = "admin123";

        public static string UserEmail => _userEmail;

        public static string UserPassword => _userPassword;

        public UserNameForTest(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        

    }
}
