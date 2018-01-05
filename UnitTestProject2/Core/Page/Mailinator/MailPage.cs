using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject2.Core.Page.Mailinator
{
    public class MailPage
    {
        public void SwitchToMailBodyFrame()
        {
            DriverManager.GetDriver().SwitchTo().Frame("msg_body");
        }

        public IWebElement MailBody
        {
            get { return DriverManager.GetDriver().FindElement(By.CssSelector("body")); }
        }

        public void WaitForBody()
        {
            Thread.Sleep(1000);
        }
    }
}
