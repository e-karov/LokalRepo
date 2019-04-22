using System;
using System.Linq;

namespace _14.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            int[] upperLeft = arr.Take(k).Reverse().ToArray();
            int[] upperRight = arr.Skip(k * 3).Take(k).Reverse().ToArray();
            int[] lowerRow = arr.Skip(k).Take(k * 2).ToArray();
            int [] upperRow = upperLeft.Union(upperRight).ToArray();    
            int[] resultArr = new int[k * 2];

            for (int i = 0; i < k * 2; i++)
            {
                resultArr[i] =upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
