using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            RoundAwayFromZero(arr);
            
        }

        static void RoundAwayFromZero(double[] array)
        {
            double[] newArr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = Math.Round((array[i]), MidpointRounding.AwayFromZero);

                Console.WriteLine(array[i] + "=> " + newArr[i] );
            }
           
        }
    }
}
