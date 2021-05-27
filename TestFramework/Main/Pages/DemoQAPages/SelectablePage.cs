using OpenQA.Selenium;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class SelectablePage
    {
        private const string GridRowLocator = "//*[@id=\"row{0}\"]/li";
        readonly ListElements SelectableList = new ListElements(By.XPath("//*[@id=\"verticalListContainer\"]/li"));
        readonly WebElement Gridtab = new WebElement(By.Id("demo-tab-grid"));

        private ListElements SelectableGridRow(int rowNumber) => new ListElements(By.XPath(string.Format(GridRowLocator, rowNumber)));

        public void SelectElementInList(int elementNumber) => SelectableList.Click(elementNumber);

        public void SelectElementInGrid(int rowNumber, int elementNumber) => SelectableGridRow(rowNumber).Click(elementNumber);

        public bool IsListElementSelected(int elementNumber) => SelectableList.GetElementAttribute(elementNumber, "class").Contains("active");

        public bool IsGridElementSelected(int rowNumber, int elementNumber) => SelectableGridRow(rowNumber).GetElementAttribute(elementNumber, "class").Contains("active");

        public void OpenGridTab() => Gridtab.Click();
    }
}
