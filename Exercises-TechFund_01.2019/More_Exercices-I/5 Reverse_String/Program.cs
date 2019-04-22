using System;

namespace _5_Reverse_String
{
    class Program
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();

            string reversed = string.Empty;

            for (int i = inputStr.Length -1; i >= 0; i--)
            {
                reversed += inputStr[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
