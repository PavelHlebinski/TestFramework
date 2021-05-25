using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestFramework.Main.Driver;

namespace TestFramework.Main.Pages
{
    public class BasePage
    {
        protected static WebDriverWait Wait;
        protected static IWebDriver Driver;

        public BasePage()
        {
            Driver = DriverFactory.InitializeDriver();
            Wait = DriverFactory.InitializeWait(DriverFactory.InitializeDriver(), 10);
        }
    }
}
