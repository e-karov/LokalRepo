using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Song_Encryption           // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string artistPattern = @"^[A-Z][a-z' ]*$";
            string songPattern = @"^[A-Z]+[A-Z ]*$";

            while (input != "end")
            {
                string[] line = input.Split(":");
                string artist = line[0];
                string song = line[1];
                Match artMatch = Regex.Match(artist, artistPattern);
                Match songMatch = Regex.Match(song, songPattern);
                StringBuilder sb = new StringBuilder();

                if (artMatch.Success && songMatch.Success )
                {
                    int key = int.Parse(artMatch.Value.Length.ToString());

                    foreach (var symbol in input)
                    {
                        char newSymbol = (char)(symbol + key);

                        if (symbol == ' ' || symbol == '\'')
                        {
                            newSymbol = symbol;
                        }

                        if (symbol == ':')
                        {
                            newSymbol = '@';
                        }

                        if (Char.IsLower(symbol) && newSymbol > 'z')
                        {
                            newSymbol = (char)(newSymbol - 26);
                        }

                        if (Char.IsUpper(symbol) && newSymbol > 'Z')
                        {
                            newSymbol = (char)(newSymbol - 26);

                        }
                        sb.Append(newSymbol);
                    }

                    Console.WriteLine($"Successful encryption: {sb}");
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
