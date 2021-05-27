using NUnit.Framework;
using TestFramework.Test.BaseTests;

namespace TestFramework.Test.Tests
{
    public class SelectablePageTests : BaseTest
    {
        [TestCase(0, 3, TestName = "Select element is List")]
        public void SelectElement(int firstElement, int secondElement)
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenSelectablePage();
            SelectablePage.SelectElementInList(firstElement);
            SelectablePage.SelectElementInList(secondElement);
            SelectablePage.IsListElementSelected(firstElement);
            SelectablePage.IsListElementSelected(secondElement);
        }

        [TestCase(1, 3, 2, 0, TestName = "Select element is Grid")]
        public void SelectElement(int firstRow, int secondRow, int firstElement, int secondElement)
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenSelectablePage();
            SelectablePage.OpenGridTab();
            SelectablePage.SelectElementInGrid(firstRow, firstElement);
            SelectablePage.SelectElementInGrid(secondRow, secondElement);
            SelectablePage.IsGridElementSelected(firstRow, firstElement);
            SelectablePage.IsGridElementSelected(secondRow, secondElement);
        }
    }
}
