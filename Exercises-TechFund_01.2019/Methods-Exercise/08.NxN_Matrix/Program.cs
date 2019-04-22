using System;

namespace _08.NxN_Matrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k == n-1)
                    {
                        Console.WriteLine(n);
                    }

                    else
                    {
                        Console.Write(n + " ");
                    }
                }

            }
        }
    }
}
