using System;
using System.Linq;

namespace Übungen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] - arr[j] == difference)
                    {
                        counter ++ ;
                    }
                }
            }

            Console.WriteLine(counter);


            
        }
    }
}
