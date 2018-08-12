using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

           PrintEqualElements(input);
        }

        static void PrintEqualElements(int[] arr1)
        {

            int max = 1;
            int digit = 0;
            for (int i = 0; i < arr1.Length-1; i++)
            {
                int counter = 0;

                for (int j = i; j < arr1.Length; j++)
                {
                    if (arr1[j] == arr1[i]) 
                    {
                        counter++;
                        if (counter > max)
                        {
                            max = counter;

                            digit =arr1[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                    
                }

                
            }
            for (int i = 0; i < max; i++)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
        }
    }
}
