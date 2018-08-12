using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Converting10_Base_To_N_Base_Number
{
    class Program
    {
        static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger @base = input[0];
            BigInteger number = input[1];
            StringBuilder sb = new StringBuilder();

            while (number > 0)
            {
                BigInteger rem = 0;

                rem = number % @base;
                number /= @base;

                sb.Append(rem);
            }

            string result = new string( sb.ToString().Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
