using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using TestFramework.Main.Driver;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class SortablePage
    {
        private readonly List<string> rightListOrder = new List<string> { "Two", "One", "Three", "Four", "Five", "Six" };
        private readonly List<string> rightGridOrder = new List<string> { "Two", "Three", "Four", "Five", "One", "Six", "Seven", "Eight", "Nine" };
        readonly ListElements SortableList = new ListElements(By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div"));
        readonly ListElements SortableGrid = new ListElements(By.XPath("//*[@id=\"demo-tabpane-grid\"]/div/div/div"));
        readonly WebElement Gridtab = new WebElement(By.Id("demo-tab-grid"));

        public void ChangeListPosition() => SortableList.DragAndDrop(0, 1);

        public bool IsListOrderCorrect() => Enumerable.SequenceEqual(rightListOrder, SortableList.GetElementsText());

        public void ChangeGridPosition()
        {
            Gridtab.Click();                       
            SortableGrid.DragAndDrop(0, 4);            
        }

        public bool IsGridOrderCorrect() => Enumerable.SequenceEqual(rightGridOrder, SortableGrid.GetElementsText());
    }
}
