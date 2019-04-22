using System;

namespace _12.Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] arr = { 1 };

            Console.WriteLine(string.Join(' ', arr));

            for (int i = 0; i < n-1; i++)
            {
                long[] nextArr = new long[arr.Length + 1];
                
                for (int k = 0; k < nextArr.Length; k++)
                {
                    int firstIndex = k - 1;
                    int secondindex = k;

                    if (firstIndex < 0 )
                    {
                        nextArr[k] = 1;
                    }
                    else if (secondindex > arr.Length-1)
                    {
                        nextArr[k] = 1;
                    }

                    else
                    {
                        nextArr[k] = arr[firstIndex] + arr[secondindex];
                    }
                }

                arr = nextArr;

                Console.WriteLine(string.Join(' ', arr));
            }

           

        }
    }
}
