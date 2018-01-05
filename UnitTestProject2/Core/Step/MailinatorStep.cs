using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using UnitTestProject2.Core.Page.Mailinator;

namespace UnitTestProject2.Core.Step
{
    class MailinatorStep
    {
        LoginPage loginPage = new LoginPage();
        InboxPage inboxPage = new InboxPage();
        MailPage mailPage = new MailPage();

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

        public void OpenMail()
        {
            inboxPage.LastMail.Click();
        }

        public void VerifyMailBody(string body)
        {
            mailPage.SwitchToMailBodyFrame();
            mailPage.WaitForBody();
            Assert.True(mailPage.MailBody.Text.Contains(body));
        }
    }
}
