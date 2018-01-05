using UnitTestProject2.Core.Page.Iua;

namespace UnitTestProject2.Core.Step
{
    class IuaStep
    {
        LoginPage loginPage = new LoginPage();
        InboxPage inboxPage = new InboxPage();
        CreateMailPage newMailPage = new CreateMailPage();

        public void Login(string login, string password)
        {
            Action.OpenSite("http://www.i.ua/");
            //DiscardPopup();
            loginPage.LoginInput.SendKeys(login);
            loginPage.PasswordInput.SendKeys(password);
            loginPage.SubmitButton.Click();
        }

        public void DiscardPopup()
        {
            loginPage.SwitchToPopupFrame();
            loginPage.DiscardPopupButton.Click();
            loginPage.ReturnToDefaultContent();
        }

        public void SendNewMail(string to, string subject, string body)
        {
            ClickCreateMailButton();
            CreateMail(to, subject, body);
        }

        private void ClickCreateMailButton()
        {
            inboxPage.CreateMailButton.Click();
        }

        private void CreateMail(string to, string subject, string body)
        {
            newMailPage.MailToInput.SendKeys(to);
            newMailPage.MailSubjectInput.SendKeys(subject);
            newMailPage.MailBodyInput.SendKeys(body);
            newMailPage.SendButton.Click();
        }
    }
}
