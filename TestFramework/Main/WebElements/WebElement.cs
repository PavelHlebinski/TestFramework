using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestFramework.Main.Driver;

namespace TestFramework.Main.WebElements
{
    public class WebElement
    {
        private readonly By _locator;
        private readonly Actions _actions = new Actions(DriverFactory.GetDriver());

        public WebElement(By locator)
        {
            _locator = locator;
        }

        public IWebElement InnerWebElement
        {
            get
            {
                WaitForElementIsPresent();
                return DriverFactory.GetDriver().FindElement(_locator);
            }
        }

        public void Click() => InnerWebElement.Click();

        public void DragAndDrop(WebElement dropTo) => _actions.ClickAndHold(InnerWebElement).MoveToElement(dropTo.InnerWebElement).Release(InnerWebElement).Build().Perform();

        public void SendKeys(string value) => InnerWebElement.SendKeys(value);

        public void WaitForElementIsPresent() => WaitFactory.GetWait(10).Until(drv => drv.FindElements(_locator).Count > 0);

        public string GetElementClassAttribute() => GetElementAttribute("class");

        public string GetElementStyleAttribute() => GetElementAttribute("style");

        private string GetElementAttribute(string attributeName) => InnerWebElement.GetAttribute(attributeName);

        public void Resize(int x, int y) => _actions.ClickAndHold(InnerWebElement).MoveByOffset(x, y).Release().Build().Perform();


    }
}
