using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", FoldAndSumArray(arr)));

        }

        static int[] FoldAndSumArray (int[] input)
        {
            int[] firstRow = new int[input.Length / 2];

            for (int i = 0; i < input.Length/4; i++)
            {
                firstRow[i] = input[(input.Length-1) * 1/ 4 - i];
                firstRow[firstRow.Length - 1 - i] = input[input.Length *3 / 4 + i];
            }

            int[] sum = new int[input.Length / 2];
            for (int i = 0; i < input.Length/2; i++)
            {
                sum[i] = firstRow[i] + input[input.Length / 4 + i];
            }

            return sum;


           
        }

       
        
    }
}
