namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            {
                user.FullName = "Mirqubad Akbarov";
                user.Email = "Mirqubad@test";
            }
            user.ShowInfo();
        }
    }
}
