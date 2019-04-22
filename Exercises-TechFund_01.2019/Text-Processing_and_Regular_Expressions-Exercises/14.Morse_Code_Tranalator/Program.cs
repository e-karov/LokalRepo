using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _14.Morse_Code_Tranalator         // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] letters = input.Split();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < letters.Length; i++)
            {
                string currentSign = letters[i].ToString();
                string currentLetter = "";

                switch (currentSign)
                {
                    case ".-":
                        currentLetter = "A";
                        break;

                    case "-...":
                        currentLetter = "B";
                        break;

                    case "-.-.":
                        currentLetter = "C";
                        break;

                    case "-..":
                        currentLetter = "D";
                        break;

                    case ".":
                        currentLetter = "E";
                        break;

                    case "..-.":
                        currentLetter = "F";
                        break;

                    case "--.":
                        currentLetter = "G";
                        break;

                    case "....":
                        currentLetter = "H";
                        break;

                    case "..":
                        currentLetter = "I";
                        break;

                    case ".---":
                        currentLetter = "J";
                        break;

                    case "-.-":
                        currentLetter = "K";
                        break;

                    case ".-..":
                        currentLetter = "L";
                        break;

                    case "--":
                        currentLetter = "M";
                        break;

                    case "-.":
                        currentLetter = "N";
                        break;

                    case "---":
                        currentLetter = "O";
                        break;

                    case ".--.":
                        currentLetter = "P";
                        break;

                    case "--.-":
                        currentLetter = "Q";
                        break;

                    case ".-.":
                        currentLetter = "R";
                        break;

                    case "...":
                        currentLetter = "S";
                        break;

                    case "-":
                        currentLetter = "T";
                        break;

                    case "..-":
                        currentLetter = "U";
                        break;

                    case "...-":
                        currentLetter = "V";
                        break;

                    case ".--":
                        currentLetter = "W";
                        break;

                    case "-..-":
                        currentLetter = "X";
                        break;

                    case "-.--":
                        currentLetter = "Y";
                        break;

                    case "--..":
                        currentLetter = "Z";
                        break;

                    case "|":
                        currentLetter = " ";
                        break;
                }

                sb.Append(currentLetter);
            }
            Console.WriteLine(sb);
        }
    }
}
