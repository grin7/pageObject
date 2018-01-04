using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject2.Core
{
    public class DriverManager
    {
        private static IWebDriver driver = null;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public static IWebDriver CloseDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
                driver = null;
            }
            return driver;
        }
    }
}
