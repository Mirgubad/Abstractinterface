namespace ConsoleApp59
{
    interface IAccount
    {

        public string Password { get; set; }

        public abstract bool PasswordChecker(string password);
        public abstract void ShowInfo();






    }
}
