using NUnit.Framework;

namespace TestFramework.Test.Tests
{
    class SortablePageTests : BaseTest
    {
        [TestCase(TestName = "Change position in list Test")]
        public void ChangeListPosition()
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenSortablePage();
            SortablePage.ChangeListPosition();
            SortablePage.IsListOrderCorrect();
        }

        [TestCase(TestName = "Change position in grid Test")]
        public void ChangeGridPosition()
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenSortablePage();
            SortablePage.ChangeGridPosition();
            SortablePage.IsGridOrderCorrect();
        }
    }
}
