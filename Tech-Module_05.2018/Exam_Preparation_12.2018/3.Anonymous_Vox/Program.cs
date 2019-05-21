using System;
using System.Text.RegularExpressions;

namespace _3.Anonymous_Vox
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] replacements = Console.ReadLine()
                .Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            MatchCollection matches = Regex.Matches(text, @"([a-zA-Z]+)(.*)(\1)");

            int index = 0;

            foreach (Match match in matches)
            {
                if (replacements.Length > index)
                {
                    if (text.Contains(match.Groups[2].Value))
                    {
                        text = text.Replace(match.Groups[2].Value, replacements[index++]);
                    }
                  
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(text); 
        }
    }
}
