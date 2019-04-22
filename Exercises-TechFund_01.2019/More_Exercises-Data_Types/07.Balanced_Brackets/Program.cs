using System;

namespace _07.Balanced_Brackets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int openingCounter = 0;
            int closingCounter = 0;

            bool isOpening = false;
            bool isClosing = false;
            bool isBallanced = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();


                if (input == "(") 
                {
                    openingCounter++;
                    isClosing = false;

                    if (isOpening)
                    {
                        isBallanced = false;
                    }
                    isOpening = true;
                }
                else if (input == ")")
                {
                    closingCounter++;
                    isOpening = false;

                    if (isClosing)
                    {
                        isBallanced = false;
                    }

                    isClosing = true;
                }
            }

            if (isBallanced && openingCounter == closingCounter)
            {
                Console.WriteLine("BALANCED");
            }

            else 
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
