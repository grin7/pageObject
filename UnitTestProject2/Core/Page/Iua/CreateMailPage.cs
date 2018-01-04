using OpenQA.Selenium;

namespace UnitTestProject2.Core.Page.Iua
{
    public class CreateMailPage
    {
        public IWebElement MailToInput
        {
            get { return DriverManager.GetDriver().FindElement(By.Id("to")); }
        }

        public IWebElement MailSubjectInput
        {
            get { return DriverManager.GetDriver().FindElement(By.Name("subject")); }
        }

        public IWebElement MailBodyInput
        {
            get { return DriverManager.GetDriver().FindElement(By.Id("text")); }
        }

        public IWebElement SendButton
        {
            get { return DriverManager.GetDriver().FindElement(By.CssSelector("p.send_container.clear > input[name=\"send\"]")); }
        }
    }
}
