using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using TestFramework.Main.Settings;

namespace TestFramework.Main.Driver
{
    public class DriverFactory
    {
        private static IWebDriver _driver;
        private static WebDriverWait _wait;

        public static IWebDriver InitializeDriver()
        {
            if (_driver == null)
            {
                _driver = SetupDriver();
            }
            return _driver;
        }

        public static WebDriverWait InitializeWait(IWebDriver driver, int timeOutInSeconds)
        {
            if (_wait == null || driver == null)
            {
                _wait = SetupDriverWait(driver, timeOutInSeconds);
            }
            return _wait;
        }

        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
            _wait = null;
        }

        public static void CloseDriver() => _driver.Close();

        private static IWebDriver SetupDriver()
        {
            if (AppSettings.ReadSettings("Browser") == "Chrome")
            {
                return new ChromeDriver();
            }
            return new EdgeDriver();
        }

        private static WebDriverWait SetupDriverWait(IWebDriver driver, int timeOutInSeconds) => new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
    }
}
