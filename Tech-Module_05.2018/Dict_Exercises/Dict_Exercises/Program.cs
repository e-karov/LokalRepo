using System;
using System.Collections.Generic;

namespace Dict_Exercises
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

=            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END" || line == "ListAll")
                {
                    break;
                }


                if (line != "ListAll")
                {

                    string[] tokens = line.Split();
                    string command = tokens[0];
                    string name = tokens[1];
                    switch (line)
                    {
                        case "A":
                            if (!phonebook.ContainsKey(name))
                            {
                                phonebook.Add(name, tokens[2]);
                            }
                            else
                            {
                                phonebook[name] = tokens[2];
                            }
                            break;

                        case "S":
                            if (phonebook.ContainsKey(name))
                            {
                                Console.WriteLine($"{name} -> {phonebook[name]}");
                            }
                            else
                            {
                                Console.WriteLine($"Contact {name} does not exist.");
                            }
                            break;
                    }

                }

            }
                foreach( var item in phonebook)
            

            
        }
    }
}
