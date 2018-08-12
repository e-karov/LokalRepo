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

        static void ReversedNumber(string numStr)
        {
            string result = "";
            //char symbol = '\0';
            //char ch = numberStr[numberStr.Length - 1];
            for (int i = numStr.Length-1; i >= 0; i--)
            {
               
                result += numStr[i];
            }
            Console.WriteLine(result);
        }
    }
}
