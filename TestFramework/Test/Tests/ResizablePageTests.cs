using NUnit.Framework;
using TestFramework.Test.BaseTests;

namespace TestFramework.Test.Tests
{
    public class ResizablePageTests : BaseTest
    {
        [TestCase(50, 50, TestName = "First Box Resize Test")]
        public void FirstBoxResize(int xOffset, int yOffset)
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenResizablePage();
            ResizablePage.FirstBoxResize(xOffset, yOffset);
            ResizablePage.IsFirstBoxResized();
        }

        [TestCase(50, 50, TestName = "Second Box Resize Test")]
        public void SecondBoxResize(int xOffset, int yOffset)
        {
            MainPage.OpenInteractionsPage();
            MainPage.OpenResizablePage();
            ResizablePage.SecondBoxResize(xOffset, yOffset);
            ResizablePage.IsSecondBoxResized();
        }
    }
}
