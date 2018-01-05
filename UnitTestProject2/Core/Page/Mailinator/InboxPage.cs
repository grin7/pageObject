using OpenQA.Selenium;

namespace UnitTestProject2.Core.Page.Mailinator
{
    public class InboxPage
    {
        public IWebElement From
        {
            get { return DriverManager.GetDriver().FindElement(By.XPath("//*[@id='inboxpane']//div[@title='FROM']")); }
        }

        public IWebElement Subject
        {
            get { return DriverManager.GetDriver().FindElement(By.XPath("//div[@class='all_message-min']/div[4]")); }
        }

        public IWebElement LastMail
        {
            get { return DriverManager.GetDriver().FindElement(By.XPath("//*[@id='inboxpane']/li[1]")); }
        }
    }
}
