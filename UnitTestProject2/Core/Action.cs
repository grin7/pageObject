namespace UnitTestProject2.Core
{
    public class Action
    {      
        public static void OpenSite(string url)
        {
            DriverManager.GetDriver().Navigate().GoToUrl(url);
        }
    }
}
