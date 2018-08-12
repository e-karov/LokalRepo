using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            bool isValid = false;
            
            for (int i = 0; i < array.Length; i++)
            {
                
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int k = i+1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    isValid = true;
                    Console.WriteLine(i);
                    break;
                }

                if (array.Length == 1)
                {
                    Console.WriteLine(0);
                }
               
            }
            if (isValid == false)
            {
                Console.WriteLine("no");
            }



        }
    }
}
