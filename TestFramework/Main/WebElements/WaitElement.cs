using OpenQA.Selenium;
using TestFramework.Main.Pages;

namespace TestFramework.Main.WebElements
{
    public class WaitElement : BasePage
    {
        public static IWebElement ClicableElement(By locator) => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));

        public static IWebElement PresentElement(By locator) => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
    }
}
