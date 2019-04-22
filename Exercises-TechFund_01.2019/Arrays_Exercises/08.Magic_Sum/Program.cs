using System;
using System.Linq;

namespace _08.Magic_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            int[] checkArr = new int[arr.Length];
            bool isZeroPrinted = false;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int k = i+1; k < arr.Length; k++)
                {
                    if (arr[i] + arr[k] == number)
                    {
                        if (number == 0 && arr[i] == 0 && arr[k] == 0)
                        {
                            if (isZeroPrinted == false)
                            {
                                Console.WriteLine("0 0");
                                isZeroPrinted = true;
                            }
                            continue;
                        }
                        
                        if (checkArr.Contains(arr[i]) )
                        {
                            continue;
                        }
                        Console.WriteLine($"{arr[i]} {arr[k]}");

                        checkArr[i] = arr[i];
                    }
                }
            }


        }
    }
}
