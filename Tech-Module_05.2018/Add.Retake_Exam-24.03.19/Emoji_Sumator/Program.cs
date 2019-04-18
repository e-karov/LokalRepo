using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Emoji_Sumator                     // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] emojiCode = Console.ReadLine().Split(':');
            string emojiName = "";
            int totalPower = 0;
            List<string> emojis = new List<string>();

            for (int i = 0; i < emojiCode.Length; i++)
            {
                emojiName += (char)(int.Parse(emojiCode[i]));
            }

            MatchCollection matches = Regex.Matches(text, @"(?<= ):(?<emoji>[a-z]{4,}):(?=[ ,.!?])");
            foreach (Match match in matches)
            {
                int power = 0;
                string emoji = match.Groups["emoji"].Value;
                emojis.Add(emoji);

                for (int i = 0; i < emoji.Length; i++)
                {
                    power += (int)emoji[i];
                }
                totalPower += power;
                
            }

            bool IsFound = false;
            foreach (var item in emojis)
            {
                if (item == emojiName)
                {
                    IsFound = true;
                }
            }

            if (IsFound)
            {
                totalPower *= 2;
            }

            if (matches.Count > 0)
            {
                Console.Write("Emojis found: ");
                Console.WriteLine(':' + String.Join(":, :", emojis) + ':');
            }
            Console.WriteLine($"Total Emoji Power: {totalPower}");
        }
    }
}
