using OpenQA.Selenium;
using ZavrsniIspit.Driver;

namespace ZavrsniIspit.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
        public IWebElement Error => driver.FindElement(By.CssSelector(".error-message-container"));

        public void Login(string user, string pass)
        {
            UserName.SendKeys(user);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
    }
}
