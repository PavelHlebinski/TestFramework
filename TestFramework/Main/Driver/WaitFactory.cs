using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFramework.Main.Driver
{
    public class WaitFactory
    {
        private static WebDriverWait _wait;

        public static WebDriverWait GetWait(int timeOutInSeconds)
        {
            if (_wait == null)
            {
                _wait = SetupWait(DriverFactory.GetDriver(), timeOutInSeconds);
            }
            return _wait;
        }

        private static WebDriverWait SetupWait(IWebDriver driver, int timeOutInSeconds) => new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));

        public static void CloseWait() => _wait = null;
    }
}
