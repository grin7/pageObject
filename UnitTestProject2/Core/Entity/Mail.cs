using System;

namespace UnitTestProject2.Core.Entity
{
    public class Mail
    {
        private string email;
        private string subject;
        private string text;

        public Mail()
        {
            Email = "page_object" + DateTimeOffset.Now.Millisecond + "@mailinator.com";
            Subject = "check subject";
            Text = "check text";
        }

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Text { get => text; set => text = value; }
    }
}
