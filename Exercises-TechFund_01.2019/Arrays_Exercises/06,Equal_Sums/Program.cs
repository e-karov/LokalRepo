using System;
using System.Linq;

namespace _06_Equal_Sums
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isEqualFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                if (i == 0 )
                {
                    leftSum = 0;
                }
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                if (i == arr.Length-1)
                {
                    rightSum = 0;
                }

                for (int k = i+1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqualFound = true;
                }
               
            }

            if (isEqualFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
