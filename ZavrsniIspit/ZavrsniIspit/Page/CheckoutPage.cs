using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ZavrsniIspit.Driver;

namespace ZavrsniIspit.Page
{
    public class CheckoutPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement ItemTotal => driver.FindElement(By.ClassName("summary_subtotal_label"));
        public IWebElement Total => driver.FindElement(By.ClassName("summary_total_label"));
        public IWebElement FinishButton => driver.FindElement(By.Id("finish"));
        public IWebElement OrderMessage => driver.FindElement(By.CssSelector(".complete-header"));

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(ItemTotal);
            element.SelectByText(text);
            SelectElement element1 = new SelectElement(Total);
            element1.SelectByText(text);
            SelectElement element2 = new SelectElement(OrderMessage);
            element2.SelectByText(text);
        }
    }
}
