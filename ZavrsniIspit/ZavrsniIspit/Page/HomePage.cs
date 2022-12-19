using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ZavrsniIspit.Driver;

namespace ZavrsniIspit.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement HomeLogo => driver.FindElement(By.CssSelector(".app_logo"));
        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement KidsTee => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement BikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement BlackTee => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Backpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement EmptyCart => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));

        public string HomeUrl = "https://www.saucedemo.com/inventory.html";
        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
    }
}
