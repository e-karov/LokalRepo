using System;

namespace _01.Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                bool isValid = true;
                string currentUsername = input[i];

                if (currentUsername.Length < 3 || currentUsername.Length > 16)
                {
                    continue;
                }

                for (int k = 0; k < currentUsername.Length;  k++)
                {
                    if (Char.IsLetterOrDigit(currentUsername[k]) == false && currentUsername[k] != '-' && currentUsername[k] != '_' )
                    {
                        isValid = false;
                        break;
                    }
                    
                }

                if (isValid)
                {
                    Console.WriteLine(currentUsername);
                }
            }
        }
    }
}
