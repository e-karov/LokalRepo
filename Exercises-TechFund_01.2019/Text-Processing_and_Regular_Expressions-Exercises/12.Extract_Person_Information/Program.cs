using System;
using System.Text.RegularExpressions;

namespace _12.Extract_Person_Information                // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                //int nameStart = input.IndexOf("@");
                //int namesEnd = input.IndexOf("|");
                //int nameLength = namesEnd -1- nameStart;
                //string name = input.Substring(nameStart + 1, nameLength);

                //int ageStart = input.IndexOf("#");
                //int agesEnd = input.IndexOf("*");
                //int ageLength = agesEnd-1 - ageStart;
                //string age = input.Substring(ageStart + 1, ageLength);

                string pattern = @"@(?<name>(.*))\|.*#(?<age>\d+)\*";
                Match match = Regex.Match(input, pattern);
                string name = match.Groups["name"].Value;
                string age = match.Groups["age"].Value;

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
