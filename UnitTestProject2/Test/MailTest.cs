using NUnit.Framework;
using UnitTestProject2.Core.Entity;
using UnitTestProject2.Core.Step;

namespace UnitTestProject2
{
    [TestFixture]
    class MailTest : BaseTest
    {
        IuaStep iuaStep = new IuaStep();
        MailinatorStep mailinatorStep = new MailinatorStep();

        User user = new User();
        Mail mail = new Mail();
        
        [Test]
        public void SendMailTest()
        {
            iuaStep.Login(user.Login, user.Pass);            
            iuaStep.SendNewMail(mail.Email, mail.Subject, mail.Text);
            mailinatorStep.Login(mail.Email);
            mailinatorStep.VerifyMail(user.Name, mail.Subject);
            mailinatorStep.OpenMail();
            mailinatorStep.VerifyMailBody(mail.Text);
        }
    }
}
