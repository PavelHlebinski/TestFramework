using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TestFramework.Main.Settings;

namespace TestFramework.Main.Driver
{
    public class DriverFactory
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                _driver = SetupDriver();
            }
            return _driver;
        }

        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
            WaitFactory.CloseWait();
        }

        private static IWebDriver SetupDriver()
        {
            if (AppSettings.ReadSettings("Browser") == "Chrome")
            {
                return new ChromeDriver();
            }
            return new EdgeDriver();
        }
    }
}
