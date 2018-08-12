using System;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            int endIndex = Math.Min(arr1.Length, arr2.Length);
            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = 0; i < endIndex; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftCounter++;
                }
                if (arr1[arr1.Length - i - 1] == arr2[arr2.Length - 1 - i])
                {
                    rightCounter++;
                }
            }
            int max = Math.Max(leftCounter, rightCounter);
            Console.WriteLine(max);
        }
    }
}
