using System;

namespace _11.Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                string currentStr = Console.ReadLine();
                int encrypted = 0;
                for (int k = 0; k < currentStr.Length; k++)
                {
                    char currentChar = currentStr[k];
                    int currentInt = 0;
                    if (currentChar == 65 || currentChar == 69 || currentChar == 73
                        || currentChar == 79 || currentChar == 85 || currentChar == 97 
                        || currentChar == 101 || currentChar == 105 || currentChar == 111 || currentChar == 117 )
                    {
                        currentInt = currentChar * currentStr.Length;
                        encrypted += currentInt;
                    }
                    else
                    {
                        currentInt = currentChar / currentStr.Length;
                        encrypted += currentInt;
                    }

                }

                result[i] = encrypted;
            }

            Array.Sort(result);
            Console.WriteLine(string.Join('\n', result));
        }
    }
}
