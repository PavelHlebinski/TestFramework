using NUnit.Framework;
using TestFramework.Main.Driver;
using TestFramework.Main.Pages.DemoQAPages;
using TestFramework.Main.Settings;

namespace TestFramework.Test.BaseTests
{
    public class BaseTest
    {
        private readonly string url = AppSettings.ReadSettings("URL");
        protected MainPage MainPage = new MainPage();
        protected DroppablePage DroppablePage = new DroppablePage();
        protected SortablePage SortablePage = new SortablePage();
        protected SelectablePage SelectablePage = new SelectablePage();
        protected ResizablePage ResizablePage = new ResizablePage();

        [SetUp]
        public void SetUp() => MainPage.OprnURL(url);

        [TearDown]
        public void OneTimeTearDown() => DriverFactory.QuitDriver();
    }
}
