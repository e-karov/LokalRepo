using System;
using System.Linq;

namespace _05.Top_Integers
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
 
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j + 1])
                    {
                        counter++;
                    }

                    else
                    {
                        break;

                    }
                }

                if (counter == arr.Length -1- i || i == arr.Length - 1)
                {
                    Console.Write($"{arr[i]} ");
                }

            }
            Console.WriteLine();
        }
    }
}
