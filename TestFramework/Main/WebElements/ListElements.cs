using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;
using TestFramework.Main.Driver;

namespace TestFramework.Main.WebElements
{
    public class ListElements : BaseActionRunner
    {
        private readonly By _locator;
        private readonly List<string> _elementsText = new List<string> { };

        public ListElements(By locator)
        {
            _locator = locator;
        }

        public List<IWebElement> InnerWebElementsList
        {
            get
            {
                WaitForElementIsPresent();
                return DriverFactory.GetDriver().FindElements(_locator).ToList();
            }
        }

        public void WaitForElementIsPresent() => WaitFactory.GetWait(10).Until(drv => drv.FindElements(_locator).Count > 0);

        public void DragAndDrop(int fromMove, int toMove) => new Actions(DriverFactory.GetDriver())
            .ClickAndHold(InnerWebElementsList[fromMove])
            .MoveToElement(InnerWebElementsList[toMove])
            .Release(InnerWebElementsList[fromMove])
            .Build()
            .Perform();

        public List<string> GetElementsText()
        {
            foreach (IWebElement element in InnerWebElementsList)
            {
                _elementsText.Add(element.Text);
            }
            return _elementsText;
        }

        public void Click(int elementNumber) => Execute(
            check: () => InnerWebElementsList[elementNumber].Click()
        );


        public string GetElementAttribute(int elementNubmer, string attributeName) => Execute(
            check: () => InnerWebElementsList[elementNubmer].GetAttribute(attributeName)
        );
    }
}

