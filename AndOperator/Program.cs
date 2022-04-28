using System;

namespace AndOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // username: admin password: 1234
            // Задание 1
            // 3 попытки по логину/parolyu

            string username, password;
            int tries = 0;

            

            while (tries < 3)
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                password = Console.ReadLine();

                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    tries++;
                    Console.WriteLine("Access denied.");
                    Console.WriteLine($"You have {3 - tries} tries left.");
                }
            }
        }
    }
}
