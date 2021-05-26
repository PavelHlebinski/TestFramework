using OpenQA.Selenium;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class DroppablePage
    {
        private WebElement DragMeButton => new WebElement(By.Id("draggable"));

        private WebElement DragToButton => new WebElement(By.Id("droppable"));

        public void DragAndDrop() => DragMeButton.DragAndDrop(DragToButton);

        public bool IsElementDropped() => DragToButton.GetElementClassAttribute().Contains("ui-state-highlight");
    }
}
