using OpenQA.Selenium;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class DroppablePage : BasePage
    {
        readonly By dragMe = By.Id("draggable");
        readonly By dragTo = By.Id("droppable");

        public void DragAndDrop()
        {
            ElementActions.DragAndDrop(dragMe, dragTo);
            ElementCheck.AttributeCheck(dragTo, "ui-state-highlight");
        }
    }
}
