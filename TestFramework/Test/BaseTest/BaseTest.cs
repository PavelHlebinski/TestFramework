using NUnit.Framework;
using TestFramework.Main.Driver;
using TestFramework.Main.Pages.DemoQAPages;
using TestFramework.Main.Settings;

namespace TestFramework.Test
{
    public class BaseTest
    {
        private readonly string url = AppSettings.ReadSettings("URL");
        protected MainPage MainPage = new MainPage();
        protected DroppablePage DroppablePage = new DroppablePage();
        protected SortablePage SortablePage = new SortablePage();

        [SetUp]
        public void SetUp() => MainPage.OprnURL(url);

        [TearDown]
        public void OneTimeTearDown() => DriverFactory.QuitDriver();
    }
}
