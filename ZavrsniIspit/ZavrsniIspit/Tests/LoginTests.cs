using ZavrsniIspit.Driver;
using ZavrsniIspit.Page;

namespace ZavrsniIspit.Tests
{
    public class LoginTests
    {
        LoginPage loginPage;
        HomePage homePage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            homePage = new HomePage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_LoginWithValidData_UserShouldBeLoggedIn()
        {
            loginPage.Login("standard_user", "secret_sauce");
            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(homePage.HomeUrl));
        }
        [Test]
        public void TC02_LoginWithValidUsernameAndInvalidPassword_UserShouldNotBeLogged()
        {
            loginPage.Login("standard_user", "123456");
            Assert.That(loginPage.Error.Displayed);
        }
        [Test]
        public void TC03_LoginWithInvalidUsernameAndValidPassword_UserShouldNotBeLogged()
        {
            loginPage.Login("123456", "secret_sauce");
            Assert.That(loginPage.Error.Displayed);
        }
        [Test]
        public void TC04_LoginWithInvalidData_UserShouldNotBeLogged()
        {
            loginPage.Login("123456", "123456");
            Assert.That(loginPage.Error.Displayed);
        }
        [Test]
        public void TC04_LoginWithoutCredentials_UserShouldNotBeLogged()
        {
            loginPage.Login("", "");
            Assert.That(loginPage.Error.Displayed);
        }
    }
}