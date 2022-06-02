using System;
namespace ConsoleApp59
{
    class User : IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {

            Console.WriteLine("Zehmet olmasa email daxil edin");
            Email = Console.ReadLine();
            do
            {
                Console.WriteLine("Zehmet olmasa sifre teyin edin");
                Password = Console.ReadLine();
                Console.WriteLine(PasswordChecker(Password));
            } while (!PasswordChecker(Password));
        }
        public bool PasswordChecker(string password)
        {
            foreach (var item in password)
            {
                password.Contains(item);
                bool digit = char.IsDigit(item);
                bool length = password.Length > 7;
                if (password == password.ToUpper() || password == password.ToLower())
                {
                    return false;
                }
                else if (length && digit)
                {
                    return true;
                }
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine(FullName);
            Console.WriteLine(Email);
        }
    }
}
