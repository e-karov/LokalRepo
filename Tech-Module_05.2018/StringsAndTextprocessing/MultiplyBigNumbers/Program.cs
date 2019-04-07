using System;
using System.Text;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
           
            StringBuilder result = new StringBuilder();
            int remainder = 0;
            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(numAsString[i].ToString());
               
                int currentProduct = digit * multiplier + remainder;
                remainder = currentProduct  / 10;

                result.Append(currentProduct % 10);
            }
            result.Append(remainder);
            string output = result.ToString().TrimEnd('0');

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
        }
    }
}
