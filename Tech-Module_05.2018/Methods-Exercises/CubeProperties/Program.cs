using System;

namespace CubeProperties
{
    class Program
    {
        static void Main()  
        {
            int n = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrom(n) && IsEven(n) && IsDivide(n))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrom(int n)
        {
            string value = n.ToString();
            bool isValid = true;

            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[i] != value[value.Length - 1 - i])
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
        static bool IsDivide(int n)
        {
            bool isValid = false;
            int lastDigit = 0;
            int sum = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                n = n / 10;
                sum += lastDigit;
            }
            //if (sum % 7 == 0) или
            if (sum / 10 == 7)
            {
                isValid = true;
            }
            return isValid;
        }
        static bool IsEven (int n)
        {
            bool isValid = true;
            int lastDigit = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                n /= 10;
                if (n % 2 == 0)
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
