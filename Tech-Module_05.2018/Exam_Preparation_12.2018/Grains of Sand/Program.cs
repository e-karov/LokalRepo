using System;
using System.Collections.Generic;
using System.Linq;

namespace Grains_of_Sand
{
    class Program
    {
        static void Main()
        {

            List<long> sands = Console.ReadLine().Split().Select(long.Parse).ToList();

            string[] inputLine = Console.ReadLine().ToLower().Split();
            
            while (inputLine[0] != "mort")
            {
                string command = inputLine[0].ToLower();

                if (inputLine[0] == "mort")
                {
                    break;
                }

                switch (command)
                {
                    case "add":
                        int value = int.Parse(inputLine[1]);
                        sands.Add(value);
                        break;

                    case "remove":
                        value = int.Parse(inputLine[1]);

                        if (sands.Contains(value))
                        {
                            sands.Remove(value);
                        }
                        else if (sands.Count-1 >= value && value >= 0)
                        {
                            sands.RemoveAt(value);
                        }
                        break;

                    case "replace":

                        value = int.Parse(inputLine[1]);
                        long replacement = long.Parse(inputLine[2]);

                        if (sands.Contains(value))
                        {
                            sands.Insert(sands.IndexOf(value), replacement);
                            sands.Remove(value);
                        }
                        
                        break;

                    case "increase":

                        value = int.Parse(inputLine[1]);

                        for (int i = 0; i < sands.Count; i++)
                        {
                            bool isFound = false;

                            if (sands[i] >= value)
                            {
                                isFound = true;

                                for (int j = 0; j < sands.Count; j++)
                                {
                                    sands[j] += sands[i];
                                    break;
                                }
                                break;
                            }
                            else if (isFound == false)
                            {
                                for (int k = 0; k < sands.Count; k++)
                                {
                                    sands[k] += sands[sands.Count - 1];
                                    
                                }
                                break;
                            }
                        }
                        break;

                    case "collapse":

                        value = int.Parse(inputLine[1]);

                        for (int i = 0; i < sands.Count; i++)
                        {
                            if (sands[i] < value)
                            {
                                sands.Remove(sands[i]);
                                i--;
                            }
                        }
                        break;
                }

                inputLine = Console.ReadLine().ToLower().Split();
            }
            Console.WriteLine(string.Join(" ", sands));
        }

    }
}
