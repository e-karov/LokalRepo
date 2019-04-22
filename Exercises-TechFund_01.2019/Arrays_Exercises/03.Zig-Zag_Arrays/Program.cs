using System;
using System.Linq;

namespace _03.Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] current = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = current[0];
                    arr2[i] = current[1];
                }
                else
                {
                    arr1[i] = current[1];
                    arr2[i] = current[0];
                }
            }

            foreach (var element in arr1)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();

            foreach (var element in arr2)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
