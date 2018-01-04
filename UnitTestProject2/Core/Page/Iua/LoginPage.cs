using OpenQA.Selenium;

namespace UnitTestProject2.Core.Page.Iua
{
    public class LoginPage
    {
        public IWebElement LoginInput
        {
            get
            {
                return DriverManager.GetDriver().FindElement(By.Name("login"));
            }
        }

        public IWebElement PasswordInput
        {
            get
            {
                return DriverManager.GetDriver().FindElement(By.Name("pass"));
            }
        }

        public IWebElement SubmitButton
        {
            get
            {
                return DriverManager.GetDriver().FindElement(By.CssSelector("p > input[type=\"submit\"]"));
            }
        }

        public IWebElement DiscardPopupButton
        {
            get
            {
                return DriverManager.GetDriver().FindElement(By.Id("close"));
            }
        }

        public void SwitchToPopupFrame()
        {
            DriverManager.GetDriver().SwitchTo().Frame("panelBig");
        }

        public void ReturnToDefaultContent()
        {
            DriverManager.GetDriver().SwitchTo().DefaultContent();
        }
    }
}
