using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string pass = String.Empty;

            for (int i = userName.Length -1 ; i >= 0 ; i--)
            {
                pass += userName[i];
            }

            string userInput = Console.ReadLine();

            int counter = 1;

            while (userInput != pass)
            {
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                counter++;

                userInput = Console.ReadLine();
            }

            if (userInput == pass)
            {
                Console.WriteLine($"User {userName} logged in.");
                return;
            }
        }
    }
}
