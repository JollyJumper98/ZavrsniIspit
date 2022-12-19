using ZavrsniIspit.Driver;
using ZavrsniIspit.Page;

namespace ZavrsniIspit.Tests
{
    public class ItemTotalTest
    {
        LoginPage loginPage;
        HomePage homePage;
        CartPage cartPage;
        InfoPage infoPage;
        CheckoutPage checkoutPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            homePage = new HomePage();
            cartPage = new CartPage();
            infoPage = new InfoPage();
            checkoutPage = new CheckoutPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_CheckItemTotalValue_ValueShouldBeConfirmerd()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.Backpack.Click();
            homePage.BikeLight.Click();
            homePage.Cart.Click();
            cartPage.Checkout.Click();
            infoPage.FirstName.SendKeys("Dusan");
            infoPage.LastName.SendKeys("Dobric");
            infoPage.PostalCode.SendKeys("22304");
            infoPage.ContinueButton.Submit();

            Assert.That("Item total: $39.98", Is.EqualTo(checkoutPage.ItemTotal.Text));
        }
        [Test]
        public void TC02_CheckTotalValue_TotalValueShouldBeConfirmed()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.KidsTee.Click();
            homePage.BlackTee.Click();
            homePage.Cart.Click();
            cartPage.Checkout.Click();
            infoPage.FirstName.SendKeys("Dusan");
            infoPage.LastName.SendKeys("Dobric");
            infoPage.PostalCode.SendKeys("22304");
            infoPage.ContinueButton.Submit();

            Assert.That("Total: $25.90", Is.EqualTo(checkoutPage.Total.Text));
        }
    }
}
