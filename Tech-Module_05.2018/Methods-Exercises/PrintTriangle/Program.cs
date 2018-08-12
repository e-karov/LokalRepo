using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTriangle(num);
           
        }

        static void PrintTriangle(int num)
        {
            PrintTriangleTop(num);
            PrintTriangleBottom(num);
        }

        private static void PrintTriangleTop(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col +" ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleBottom(int num)
        {
            for (int row = num-1; row > 0; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
