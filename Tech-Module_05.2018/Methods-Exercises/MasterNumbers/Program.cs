using System;

namespace MasterNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                bool isDivisibleBySeven = SumDivisibleBy7(i);
                bool holdsEvenDigit = ContainsEvenDigit(i);

                if (isPalindrome && isDivisibleBySeven && holdsEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsPalindrome(int number)
        {
            string reversed = "" ;
            string numAsString = number.ToString();

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                reversed += numAsString[i];
            }
            int reversedNumber = int.Parse(reversed);
            bool isPalindrome = numAsString == reversed;

            return isPalindrome;
        }

        static bool SumDivisibleBy7(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;

                num /= 10;
            }

            bool divisible7 = sum % 7 == 0;

            return divisible7;
        }

        static bool ContainsEvenDigit(int num)
        {
            bool evenDigit = false;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    evenDigit = true;
                    break;
                }
                num /= 10;
            }
            return evenDigit;
        }
    }
}
