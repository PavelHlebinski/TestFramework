using NUnit.Framework;

namespace TestFramework.Test.Tests
{
    public class DroppablePageTests : BaseTest
    {
        [TestCase(TestName = "Drag and Drop Test")]
        public void DADTest()
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenDroppablePage();
            DroppablePage.DragAndDrop();
        }
    }
}
