using System;

namespace _13.Recursive_Fibonacci
{

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long fibNum = GetFibonacciRecursive(n);
            Console.WriteLine(fibNum);
        }

        static int GetFibonacciRecursive(int num)
        {

            int[] arrFibonacci = new int[num + 1];
            DateTime startTime = DateTime.Now;

            for (int i = 0; i <= num; i++)
            {
                if (i == 0 || i == 1)
                {
                    arrFibonacci[i] = 1;
                }
                else
                {
                    arrFibonacci[i] = arrFibonacci[i - 2] + arrFibonacci[i - 1];
                }
            }
            return arrFibonacci[num - 1];
        }

        //static long GetFibonacciSimple(int num)
        //{
        //    long num1 = 1;
        //    long num2 = 1;
        //    long fibNum = 0;

        //    for (int i = 2; i < num; i++)
        //    {
        //        fibNum = num1 + num2;

        //        num1 = num2;
        //        num2 = fibNum;
        //    }

        //    return fibNum;
        //}

        //static long GetFibMemoized(long num, bool isMemo = true)
        //{
        //    long[] fibArray = new long[num + 1];
        //    if (isMemo)
        //    {
        //        if (fibArray[num] != 0)
        //        {
        //            return fibArray[num];
        //        }
        //    }

        //    if (num == 0)
        //    {
        //        return 0;
        //    }
        //    if (num == 1)
        //    {
        //        return 1;
        //    }

        //    fibArray[num] = GetFibMemoized(num - 1, isMemo) + GetFibMemoized(num - 2, isMemo);

        //    return fibArray[num];

        //}
    }
}
