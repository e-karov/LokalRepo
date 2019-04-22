using System;

namespace _11.Top_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopNumbers(n);
        }

        static void PrintTopNumbers(int number)
        {
            
            for (int i = 1; i < number; i++)
            {
                bool isTopNum = true;
                int currenentNum = i;
                int sum = 0;
                int oddDigitCounter = 0;

                while (currenentNum > 0)
                {
                    int digit = currenentNum % 10;
                    sum += digit;
                    currenentNum /= 10;

                    if (digit % 2 != 0)
                    {
                        oddDigitCounter++;
                    }
                }

                if (sum % 8 != 0 || oddDigitCounter == 0)
                {
                    isTopNum = false;
                    continue;
                }

                if (isTopNum)
                {
                    Console.WriteLine(i);
                }
            }

            
        }
    }
}
