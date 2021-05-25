using NUnit.Framework;
using OpenQA.Selenium;

namespace TestFramework.Main.WebElements
{
    public class ElementCheck
    {
        public static void AttributeCheck(By locator, string compareText) => Assert.That(WaitElement.PresentElement(locator).GetAttribute("Class"), Does.Contain(compareText));
    }
}
