using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZavrsniIspit.Driver;

namespace ZavrsniIspit.Page
{
    public class CartPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement RemoveBackpack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement RemoveBlackTee => driver.FindElement(By.Id("remove-sauce-labs-bolt-t-shirt"));
        public IWebElement BackToShop => driver.FindElement(By.Id("continue-shopping"));
        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));
    }
}
