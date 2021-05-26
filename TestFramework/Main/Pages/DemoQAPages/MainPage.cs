using OpenQA.Selenium;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class MainPage : BasePage
    {
        private const string MainButtonLocator = "//div[@class=\"card mt-4 top-card\"]//*[text()='{0}']";
        private const string ExpandedButtonLocator = "//*[@class=\"btn btn-light \"]//*[text()='{0}']";

        private WebElement InteractionsButton => new WebElement(By.XPath(string.Format(MainButtonLocator, "Interactions")));

        private WebElement DroppableButton => new WebElement(By.XPath(string.Format(ExpandedButtonLocator, "Droppable")));

        public void OpenPage(string URL) => OprnURL(URL);

        public void OpenPageForTests()
        {
            InteractionsButton.Click();
            DroppableButton.Click();
        }
    }
}
