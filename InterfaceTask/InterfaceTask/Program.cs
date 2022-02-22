using System;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad daxil edin");
            string username = Console.ReadLine();
            User username1 = new User();
            username1.Name = username;

            Console.WriteLine("Email daxil edin");
            string email = Console.ReadLine();
            username1.Email = new email;

            Console.WriteLine("Parol daxil edin");
            string password = Console.ReadLine();
            username1.PassWordChecker(password);

            Console.WriteLine("Qeydiyyatdan kecdiniz");
            Console.WriteLine($"{username1.ShowInfo()}");
        }
    }
}
