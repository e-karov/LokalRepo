using System;
using System.Linq;

namespace EqualD
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (inputArray.Length == 1)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            bool isValid = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += inputArray[j];
                }
                for (int k = i + 1; k < inputArray.Length; k++)
                {
                    rightSum += inputArray[k];
                }
                if (leftSum == rightSum)
                {
                    isValid = true;
                    Console.WriteLine(i);
                    break;
                }

            }
            
            if (isValid == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
