using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestFramework.Main.Pages;

namespace TestFramework.Main.WebElements
{
    public class ElementActions : BasePage
    {
        public static void ClickButton(By locator) => WaitElement.ClicableElement(locator).Click();

        public static void DragAndDrop(By locator1, By locator2)
        {
            var element1 = WaitElement.PresentElement(locator1);
            var element2 = WaitElement.PresentElement(locator2);
            var builder = new Actions(Driver);
            var dragAndDrop = builder.ClickAndHold(element1).MoveToElement(element2).Release(element1).Build();
            dragAndDrop.Perform();
        }
    }
}
