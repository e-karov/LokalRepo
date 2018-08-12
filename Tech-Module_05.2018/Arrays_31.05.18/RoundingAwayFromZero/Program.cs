using System;
using System.Linq;

namespace RoundingAwayFromZero
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] result = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    result[i] = Math.Abs(numbers[i]) + 0.5;
                    result[i] = -(Math.Truncate(result[i]));

                }
                else
                {
                    result[i] = Math.Truncate(numbers[i] + 0.5);
                }
                
            }
            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine($"{numbers[i]} => {result[i]}");
            }
        }

    }
}