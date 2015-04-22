using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace SeleniumTestTemplate.Helpers
{
    public class SeleniumDriverHelper
    {
        public static IWebDriver GetDriver()
        {
            return GetDriver(string.Empty);
        }

        public static IWebDriver GetDriver(string driver)
        {
            IWebDriver webDriver;
            switch (driver.ToLower())
            {
                case "safari":
                    webDriver = new SafariDriver();
                    break;
                case "chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "ie":
                    webDriver = new InternetExplorerDriver();
                    break;
                //case "firefox":
                default:
                    webDriver = new FirefoxDriver();
                    break;
            }
            return webDriver;
        }
    }
}
