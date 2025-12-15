using System;

class Program
{
    static void Main()
    {
        string correctLogin = "admin";
        string correctPassword = "1234";

        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter Login: ");
            string login = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (login == correctLogin && password == correctPassword)
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect login or password!");
                Console.WriteLine("Attempts left: " + (3 - attempts));
            }
        }

        if (attempts == 3)
        {
            Console.WriteLine("User rejected! Too many wrong attempts.");
        }
    }
}
