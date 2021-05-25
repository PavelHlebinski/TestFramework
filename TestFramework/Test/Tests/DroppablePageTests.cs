using NUnit.Framework;

namespace TestFramework.Test.Tests
{
    public class DroppablePageTests : BaseTest
    {
        [TestCase(TestName = "Drag and Drop Test")]
        public void DADTest()
        {
            MainPage.OpenPageForTests();
            DroppablePage.DragAndDrop();
        }
    }
}
