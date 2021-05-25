using OpenQA.Selenium;
using System;
using TestFramework.Main.WebElements;

namespace TestFramework.Main.Pages.DemoQAPages
{
    public class MainPage : BasePage
    {
        public void OpenPage(string url)
        {
            try
            {
                Driver.Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }

        public void OpenPageForTests()
        {
            ElementActions.ClickButton(MainButton("Interactions"));
            ElementActions.ClickButton(ExpandedButton("Droppable"));
        }

        private static By MainButton(string buttonName) => By.XPath($"//div[@class=\"card mt-4 top-card\"]//*[text()='{buttonName}']");

        private static By ExpandedButton(string buttonName) => By.XPath($"//*[@class=\"btn btn-light \"]//*[text()='{buttonName}']");
    }
}
