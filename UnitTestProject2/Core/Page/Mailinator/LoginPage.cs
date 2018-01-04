using OpenQA.Selenium;

namespace UnitTestProject2.Core.Page.Mailinator
{
    public class LoginPage
    {
        public IWebElement LoginInput
        {
            get { return DriverManager.GetDriver().FindElement(By.Id("inboxfield")); }
        }

        public IWebElement OpenInboxButton
        {
            get { return DriverManager.GetDriver().FindElement(By.XPath("//input[@id='inboxfield']/following-sibling::span/button")); }
        }
    }
}
