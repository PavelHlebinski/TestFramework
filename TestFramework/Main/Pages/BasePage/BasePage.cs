using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestFramework.Main.Driver;

namespace TestFramework.Main.Pages
{
    public class BasePage
    {
        protected static WebDriverWait Wait;
        protected static IWebDriver Driver;

        public void OprnURL(string url)
        {
            try
            {
                DriverFactory.GetDriver().Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }
    }
}
