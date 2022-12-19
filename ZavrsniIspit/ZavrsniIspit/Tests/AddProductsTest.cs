using ZavrsniIspit.Driver;
using ZavrsniIspit.Page;

namespace ZavrsniIspit.Tests
{
    public class AddProductsTest
    {
        LoginPage loginPage;
        HomePage homePage;
        CartPage cartPage; 

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            homePage = new HomePage();
            cartPage = new CartPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_AddThreeCheapestProductsInCart_ProductsShouldBeVisibleInCart()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.SelectOption("Price (low to high)");
            homePage.KidsTee.Click();
            homePage.BikeLight.Click();
            homePage.BlackTee.Click();

            Assert.That("3", Is.EqualTo(homePage.Cart.Text));
        }
        [Test]
        public void TC02_DeleteProductsFromCart_ProductsShouldBeDeletedFromCart()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.Backpack.Click();
            homePage.BlackTee.Click();
            homePage.Cart.Click();
            cartPage.RemoveBackpack.Click();
            cartPage.RemoveBlackTee.Click();
            cartPage.BackToShop.Click();

            Assert.That(homePage.EmptyCart.Displayed);
        }
    }
}
