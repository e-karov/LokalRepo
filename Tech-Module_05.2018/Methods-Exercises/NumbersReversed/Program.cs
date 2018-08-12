using System;

namespace NumbersReversed
{
    class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();
            ReversedNumber((num));
        }

        static void ReversedNumber(string numberStr)
        {
            string result = "";
            //char symbol = '\0';
            //char ch = numberStr[numberStr.Length - 1];
            for (int i = numberStr.Length-1; i >= 0; i--)
            {
               
                result += numberStr[i];
            }
            Console.WriteLine(result);
        }
    }
}
