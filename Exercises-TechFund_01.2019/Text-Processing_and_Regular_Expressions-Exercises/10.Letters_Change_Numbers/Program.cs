using System;
using System.Text.RegularExpressions;


namespace _10.Letters_Change_Numbers                // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"([A-Za-z]+)(\d+)([A-Za-z]+)");
            double totalSum = 0;

            foreach (Match match in matches)
            {
                int position = 0;
                char firstLetter = match.Groups[1].Value[0];
                char secondLetter = match.Groups[3].Value[0];
                double number = double.Parse(match.Groups[2].Value);

                if (Char.IsUpper(firstLetter))
                {
                    position = (int)firstLetter - 64;
                    number = number / position;
                }

                if (Char.IsLower(firstLetter))
                {
                    position = (int)firstLetter - 96;
                    number = number * position;
                }

                if (Char.IsUpper(secondLetter))
                {
                    position = (int)secondLetter - 64;
                    number = number - position;
                }

                if (Char.IsLower(secondLetter))
                {
                    position = (int)secondLetter - 96;
                    number = number + position;
                }
                totalSum += number;
            }

            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
