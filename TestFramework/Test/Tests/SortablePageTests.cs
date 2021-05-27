using NUnit.Framework;
using System.Linq;
using TestFramework.Test.BaseTests;

namespace TestFramework.Test.Tests
{
    class SortablePageTests : BaseTest
    {

        [TestCase(new object[] { "Three", "Two", "One", "Four", "Five", "Six" }, TestName = "Change position in list Test")]
        public void ChangeListPosition(params string[] checkList)
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenSortablePage();
            SortablePage.ChangeListPosition();
            SortablePage.IsListOrderCorrect(checkList.ToList());
        }

        [TestCase(new object[] { "Two", "Three", "Four", "Five", "One", "Six", "Seven", "Eight", "Nine" }, TestName = "Change position in grid Test")]
        public void ChangeGridPosition(params string[] checkList)
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenSortablePage();
            SortablePage.ChangeGridPosition();
            SortablePage.IsGridOrderCorrect(checkList.ToList());
        }
    }
}
