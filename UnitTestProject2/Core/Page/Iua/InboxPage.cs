using OpenQA.Selenium;

namespace UnitTestProject2.Core.Page.Iua
{
    public class InboxPage
    {
        public IWebElement CreateMailButton 
        {
            get { return DriverManager.GetDriver().FindElement(By.CssSelector("p.make_message > a")); }
        }
    }
}
