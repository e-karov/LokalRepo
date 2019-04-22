using System;

namespace _06.Decrypting_Messages
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string message = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char current = char.Parse(Console.ReadLine());
                message += (char)((int)current + key);
            }

            Console.WriteLine(message);
        }

    }
}
