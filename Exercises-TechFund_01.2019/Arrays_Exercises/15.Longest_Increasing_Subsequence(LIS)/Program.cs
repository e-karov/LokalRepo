using System;
using System.Linq;

namespace _15.Longest_Increasing_Subsequence_LIS_
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestLen = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int len = 0;
                int nextIndex = i + 1;
                if (i == arr.Length-1)
                {
                    break;
                }
                if (arr[i] < arr[nextIndex])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                    }
                    else
                    {
                        len = 0;
                    }
                }


            }
        }
    }
}
