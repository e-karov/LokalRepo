using System;

namespace Test_BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            string symbol = string.Empty;
            byte numberOfOpeningBrackets = 0;
            byte numberOfClosingBrackets = 0;
            string previousBracket = string.Empty;
            string result = string.Empty;

            for (int i = 1; i <= numberOfLines; i++)
            {

                symbol = Console.ReadLine();

                if (symbol == "(" || symbol == ")")
                {

                    string currentBracket = symbol;

                    if (symbol == "(")
                    {
                        numberOfOpeningBrackets++;


                    }
                    else if (symbol == ")")
                    {
                        numberOfClosingBrackets++;



                    }

                    if (currentBracket == previousBracket ||
                        numberOfClosingBrackets != numberOfOpeningBrackets)
                    {
                        result = "UNBALANCED";
                    }

                    else result = "BALANCED";

                    previousBracket = currentBracket;

                }

            }
            Console.WriteLine(result);
        }
    }
}
