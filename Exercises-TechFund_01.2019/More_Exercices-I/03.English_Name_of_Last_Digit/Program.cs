using System;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(LastDigitsName(number));
        }

        static string LastDigitsName (int num)
        {
            int digit = num % 10;
            string name = "";

            if (digit == 0)
            {
                name = "zero";
            }

            else if (digit == 1)
            {
                name = "one";
            }

            else if (digit == 2)
            {
                name = "two";
            }

            else if (digit == 3)
            {
                name = "three";
            }

            else if (digit == 4)
            {
                name = "four";
            }

            else if (digit == 5)
            {
                name = "five";
            }

            else if (digit == 6)
            {
                name = "six";
            }

            else if (digit == 7)
            {
                name = "seven";
            }

            else if (digit == 8)
            {
                name = "eight";
            }

            else if (digit == 9)
            {
                name = "nine";
            }

            return name;
        }
    }
}
