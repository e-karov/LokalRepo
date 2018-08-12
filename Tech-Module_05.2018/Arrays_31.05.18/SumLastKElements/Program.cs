using System;

namespace SumLastKElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;
            SumLastKElements(k, sequence);

            Console.WriteLine(string.Join(" ", sequence));
        }

        private static void SumLastKElements(int k, long[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                int startIndex = Math.Max(0, (i - k));
                long sum = 0;

                for (int j = startIndex; j <= i; j++)
                {
                    sum += sequence[j];
                }
                sequence[i] = sum;
            }
        }
    }
}
