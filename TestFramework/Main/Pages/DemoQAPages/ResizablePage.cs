using OpenQA.Selenium;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class ResizablePage
    {
        readonly WebElement FirstReszableBox = new WebElement(By.Id("resizableBoxWithRestriction"));
        readonly WebElement FirstBoxCorner = new WebElement(By.XPath("//*[@id=\"resizableBoxWithRestriction\"]/span"));
        readonly WebElement SecondReszableBox = new WebElement(By.Id("resizable"));
        readonly WebElement SecondBoxCorner = new WebElement(By.XPath("//*[@id=\"resizable\"]/span"));

        public void FirstBoxResize(int xOffset, int yOffset) => FirstBoxCorner.Resize(xOffset, yOffset);

        public void SecondBoxResize(int xOffset, int yOffset) => SecondBoxCorner.Resize(xOffset, yOffset);

        public bool IsFirstBoxResized() => IsCorrectStyle(FirstReszableBox);

        public bool IsSecondBoxResized() => IsCorrectStyle(SecondReszableBox);

        private bool IsCorrectStyle (WebElement element) => element.GetElementStyleAttribute().Equals("width: 250px; height: 250px;");
    }
}
