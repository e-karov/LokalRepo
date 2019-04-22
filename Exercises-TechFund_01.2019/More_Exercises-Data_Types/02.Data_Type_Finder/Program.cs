using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.Data_Type_Finder
{
    class Program
    {
        static void Main()
        {
            
            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    Environment.Exit(0);
                }

                bool isNumber =  BigInteger.TryParse(input, out BigInteger number);

                if (isNumber)
                {
                    Console.WriteLine($"{number} is integer type");
                    continue;
                    
                }

                bool isFloat = double.TryParse(input, out double floatNum);

                if (isFloat)
                {
                    Console.WriteLine($"{floatNum} is floating point type");
                    continue;
                }

                if (input.ToLower()== "true" || input.ToLower() == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                    continue;
                }

                bool isChar = char.TryParse(input, out char character);

                if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                    continue;
                }


                if (input.Length > 1)
                {
                    Console.WriteLine($"{input} is string type");
                    continue;
                }

                
               
            }
        }
    }
}
