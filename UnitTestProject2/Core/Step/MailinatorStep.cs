using NUnit.Framework;
using UnitTestProject2.Core.Page.Mailinator;

namespace UnitTestProject2.Core.Step
{
    class MailinatorStep
    {
        LoginPage loginPage = new LoginPage();
        InboxPage inboxPage = new InboxPage();

        public void Login(string login)
        {
            Action.OpenSite("https://www.mailinator.com/");
            loginPage.LoginInput.SendKeys(login);
            loginPage.OpenInboxButton.Click();
        }
        
        public void VerifyMail(string from, string subject)
        {
            Assert.AreEqual(from, inboxPage.From.Text);
            Assert.AreEqual(subject, inboxPage.Subject.Text);
        }
    }
}
