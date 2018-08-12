using System;
using System.Linq;
using System.Numerics;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string string1 = input[0];
            string string2 = input[1];
            BigInteger result = 0;
            int maxLength = Math.Max(string1.Length, string2.Length);
            int minLength = Math.Min(string1.Length, string2.Length);

            for (int i = 0; i < minLength; i++)
            {
                result += string1[i] * string2[i];
            }

            for (int i = 0; i < (maxLength - minLength); i++)
            {
                if (string1.CompareTo(string2) > 0)
                {
                    string subStr = string1.Substring(minLength - 1);
                    result += subStr[i];
                }
                else if ((string1.CompareTo(string2) < 0))
                {
                    string subStr = string2.Substring(minLength - 1);
                    result += subStr[i];

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
