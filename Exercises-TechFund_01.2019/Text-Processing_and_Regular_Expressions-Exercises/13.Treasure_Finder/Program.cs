using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _13.Treasure_Finder           // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int [] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();

            while (text != "find")
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < text.Length ; i++)
                {
                    char letter = '\0';

                    if (text.Length <= key.Length)
                    {
                        letter = (char)((int)text[i] - key[i]);
                    }

                    else
                    {
                        letter = (char)((int)text[i] - key[i % key.Length]);
                    }
                    sb.Append(letter);
                }

                string decrypted = sb.ToString();
                Match match = Regex.Match(decrypted, @"&(\w+)&.*<(\d*\w*)>");

                string type = match.Groups[1].Value;
                string coordiinates = match.Groups[2].Value;
                Console.WriteLine($"Found {type} at {coordiinates}");

                text = Console.ReadLine();
            }
            
        }
    }
}
