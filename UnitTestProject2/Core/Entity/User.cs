namespace UnitTestProject2.Core.Entity
{
    public class User
    {
        private string login;
        private string name;
        private string pass;

        public User()
        {
            Login = "ivan.test";
            Name = "ivan Test";
            Pass = "ivan123456";
        }

        public string Login { get => login; set => login = value; }
        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
