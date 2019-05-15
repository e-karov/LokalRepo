using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Actrivation_Keys              // 100 /100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] keys = input.Split("&");
            List<string> changedKeys = new List<string>();


            for (int i = 0; i < keys.Length; i++)
            {
                string key = keys[i];
                string keyPattern = @"^[A-Za-z0-9]+$";
                Match match = Regex.Match(key, keyPattern);

                if (! match.Success)
                {
                    continue;
                }

                if (!(key.Length == 16 || key.Length == 25 ))
                {
                    continue;
                }

                else
                {
                    for (int k = 0; k < key.Length; k++)
                    {
                        if (Char.IsDigit(key[k]))
                        {
                            string newValue = (9 - int.Parse(key[k].ToString())).ToString();
                            key = key.Remove(k, 1);
                            key = key.Insert(k, newValue);
                        }


                    }

                    if (key.Length == 16)
                    {

                        key = key.Insert(4, "-");
                        key = key.Insert(9, "-");
                        key = key.Insert(14, "-");

                    }

                    if (key.Length == 25)
                    {
                        key = key.Insert(5, "-");
                        key = key.Insert(11, "-");
                        key = key.Insert(17, "-");
                        key = key.Insert(23, "-");
                    }


                }
                key = key.ToUpper();
                changedKeys.Add(key);
            }

            Console.WriteLine(string.Join(", ", changedKeys));
        }
    }
}
