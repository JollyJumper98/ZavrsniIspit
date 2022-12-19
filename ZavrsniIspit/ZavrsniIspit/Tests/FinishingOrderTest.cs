using ZavrsniIspit.Driver;
using ZavrsniIspit.Page;

namespace ZavrsniIspit.Tests
{
    public class FinishingOrderTest
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
        public void TC01_FinishingOrder_OrderShouldBeCompleted()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.BikeLight.Click();
            homePage.Backpack.Click();
            homePage.BlackTee.Click();
            homePage.Cart.Click();
            cartPage.Checkout.Click();
            infoPage.FirstName.SendKeys("Dusan");
            infoPage.LastName.SendKeys("Dobric");
            infoPage.PostalCode.SendKeys("22304");
            infoPage.ContinueButton.Submit();
            checkoutPage.FinishButton.Submit();

            Assert.That("THANK YOU FOR YOUR ORDER", Is.EqualTo(checkoutPage.OrderMessage.Text));
        }
    }
}
