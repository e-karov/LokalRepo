using System;
using System.Collections.Generic;

namespace Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLog = new List<string>();

            string[] inputLine = Console.ReadLine().Split();
            string command = inputLine[0];

            while (command != "end")
            {
                string message = "";

                switch (command)
                {
                    case "Chat":
                        message = inputLine[1];
                        chatLog.Add(message);

                        break;

                    case "Delete":
                        message = inputLine[1];

                        if (chatLog.Contains(message))
                        {
                            chatLog.Remove(message);
                        }

                        break;

                    case "Edit":
                        message = inputLine[1];
                        string editedMessage = inputLine[2];

                        if (chatLog.Contains(message))
                        {
                            chatLog.Insert(chatLog.IndexOf(message), editedMessage);
                            chatLog.Remove(message);
                        }
                        break;

                    case "Pin":
                        message = inputLine[1];

                        if (chatLog.Contains(message))
                        {
                            chatLog.Remove(message);
                            chatLog.Add(message);
                        }
                        break;

                    case "Spam":
                        for (int i = 1; i < inputLine.Length; i++)
                        {
                            chatLog.Add(inputLine[i]);
                        }
                        break;

                }

                inputLine = Console.ReadLine().Split();
                command = inputLine[0];
            }

            Console.WriteLine(string.Join("\n", chatLog));
        }
    }
}
