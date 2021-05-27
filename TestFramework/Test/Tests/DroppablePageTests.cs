using NUnit.Framework;
using TestFramework.Test.BaseTests;

namespace TestFramework.Test.Tests
{
    public class DroppablePageTests : BaseTest
    {
        [TestCase(TestName = "Drag and Drop Test")]
        public void DragAndDropTest()
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenDroppablePage();
            DroppablePage.DragAndDrop();
        }
    }
}
