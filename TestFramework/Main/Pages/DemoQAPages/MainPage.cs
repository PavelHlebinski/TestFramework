using OpenQA.Selenium;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class MainPage : BasePage
    {
        private const string MainButtonLocator = "//div[@class=\"card mt-4 top-card\"]//*[text()='{0}']";
        private const string ExpandedButtonLocator = "//*[@class=\"btn btn-light \"]//*[text()='{0}']";

        private WebElement MainButton(string mainButtonName) => new WebElement(By.XPath(string.Format(MainButtonLocator, mainButtonName)));

        private WebElement ExpandButton(string expandButtonName) => new WebElement(By.XPath(string.Format(ExpandedButtonLocator, expandButtonName)));

        public void OpenPage(string URL) => OprnURL(URL);

        public void OpenInteractionsPage() => MainButton("Interactions").Click();

        public void OpenDroppablePage() => ExpandButton("Droppable").Click();

        public void OpenSortablePage() => ExpandButton("Sortable").Click();

    }
}
