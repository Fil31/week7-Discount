using System;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // OR - || - "Или"
            // username: admin password: 1234

            string username, password;
            int tries = 0;
            
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            password = Console.ReadLine();

            if(username != "admin" || password != "1234")
            {
                Console.WriteLine("Access denied.");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
        }
    }
}
