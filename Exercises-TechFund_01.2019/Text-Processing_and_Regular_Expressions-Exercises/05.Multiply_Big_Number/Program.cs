using System;
using System.Text;

namespace _05.Multiply_Big_Number               // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string numStr = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            if (numStr == "0" || multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int reminder = 0;

            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                int currentDigit = 0;
                int currentProduct = multiplier * int.Parse(numStr[i].ToString()) + reminder;
                reminder = currentProduct / 10;
                currentDigit = currentProduct % 10;

                result.Insert(0, currentDigit);
            }
                result.Insert(0, reminder);

            string output = result.ToString().TrimStart('0');
            Console.WriteLine(output);
        }
    }
}
