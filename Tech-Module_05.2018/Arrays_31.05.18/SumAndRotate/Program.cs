using System;

namespace SumAndRotate
{
    class Program
    {
        static void Main()
        {
            int[] input = ParseArray(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] sumArray = new int[input.Length];
        }

        static int[] ParseArray(string input)
        {
            string[] symbols = input.Split();
            int[] result = new int[symbols.Length];

            for (int i = 0; i < symbols.Length; i++)
            {
                result[i] = int.Parse(symbols[i]);
            }
            return result;
        }

        static void ShiftArrRight(int[] arr)
        {
            int last = arr[arr.Length - 1];
            for (int i = arr.Length- 1; i > 0; i--)
            {
                arr[i] = arr[i+1];
            }
            arr[0] = last;
        }

        static void SumArrays(int[] result, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] += arr[i];
            }
            
        }
    }
}
