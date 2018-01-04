using NUnit.Framework;
using OpenQA.Selenium;
using System;
using UnitTestProject2.Core;

namespace UnitTestProject2
{
    [TestFixture]
    public abstract class BaseTest
    {
        private IWebDriver driver;

        [SetUp]
        public void TestInitialize()
        {
            driver = DriverManager.GetDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TestCleanup()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver = DriverManager.CloseDriver();
        }
    }
}
