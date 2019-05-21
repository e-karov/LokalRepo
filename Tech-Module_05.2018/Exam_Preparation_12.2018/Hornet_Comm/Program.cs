using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> privateList = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> broadcastList = new List<KeyValuePair<string, string>>();
            string message = "";

            while (true)
            {
                if (message == "Hornet is Green")
                {
                    break;
                }

                message = Console.ReadLine();

                Match privateMatch = Regex.Match(message, @"^([\d]+) <-> ([\d?A-Za-z]+)$");
                Match broadMatch = Regex.Match(message, @"^([\D]+) <-> ([a-zA-Z\d?]+)$");

                if (privateMatch.Success)
                {
                    string recepientCode = privateMatch.Groups[1].Value;
                    string privateMessage = privateMatch.Groups[2].Value;
                    string reversedCode = "";

                    for (int i = recepientCode.Length-1; i >= 0 ; i--)
                    {

                        reversedCode += recepientCode[i];
                    }

                    privateList.Add(new KeyValuePair<string, string>(reversedCode, privateMessage));
                    
                }
                else if (broadMatch.Success)
                {
                    string broadMessage = broadMatch.Groups[1].Value;
                    string broadFreq = broadMatch.Groups[2].Value;
                    
                    string newFrequency = "";
                    foreach (var letter in broadFreq)
                    {
                        
                        if (char.IsLetter(letter))
                        {
                            if (char.IsLower(letter))
                            {
                                newFrequency += char.ToUpper(letter);
                            }
                            else if (char.IsUpper(letter))
                            {
                                newFrequency += char.ToLower(letter);
                            }
                        }
                        else
                        {
                            newFrequency += letter;
                        }
                        
                    }

                    broadcastList.Add(new KeyValuePair<string, string>(newFrequency, broadMessage));
                }
            }

            Console.WriteLine("Broadcasts:");

            if (broadcastList.Count > 0)
            {
                foreach (var kvp in broadcastList)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }

            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (privateList.Count > 0)
            {
                foreach (var kvp in privateList)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
