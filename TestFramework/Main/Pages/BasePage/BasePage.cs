using OpenQA.Selenium;
using System;
using TestFramework.Main.Driver;

namespace TestFramework.Main.Pages
{
    public class BasePage
    {       
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
