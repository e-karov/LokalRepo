using System;

namespace _04.Password_Validator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            CheckPassValidity(password);
        }

        private static void CheckPassValidity(string pass)
        {
            if (CheckPassLength(pass) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (CheckChars(pass) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (CheckDigitsCount(pass) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckPassLength(pass) && CheckChars(pass) && CheckDigitsCount(pass))
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckPassLength(string pass)
        {
            bool isLengthValid = false;
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                isLengthValid = true;
            }
            return isLengthValid;
        }

        static bool CheckChars(string pass)
        {
            bool valildChars = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if(Char.IsLetterOrDigit(pass[i]) == false)
                {
                    valildChars = false;
                    break;
                }
            }
            return valildChars;
        }

        static bool CheckDigitsCount(string pass)
        {
            int digitCounter = 0;
            bool isDigitCountValid = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsDigit(pass[i]))
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= 2)
            {
                isDigitCountValid = true;
            }
            return isDigitCountValid;
        }
    }
}
