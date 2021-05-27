using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class SortablePage
    {
        readonly ListElements SortableList = new ListElements(By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div"));
        readonly ListElements SortableGrid = new ListElements(By.XPath("//*[@id=\"demo-tabpane-grid\"]/div/div/div"));
        readonly WebElement Gridtab = new WebElement(By.Id("demo-tab-grid"));

        public void ChangeListPosition() => SortableList.DragAndDrop(0, 2);

        public bool IsListOrderCorrect(List<string> checkList) => Enumerable.SequenceEqual(checkList, SortableList.GetElementsText());

        public void ChangeGridPosition()
        {
            Gridtab.Click();
            SortableGrid.DragAndDrop(0, 4);
        }

        public bool IsGridOrderCorrect(List<string> checkList) => Enumerable.SequenceEqual(checkList, SortableGrid.GetElementsText());
    }
}
