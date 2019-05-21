using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Problem_8._Take_Skip_Rope
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, long>> directories = new Dictionary<string, Dictionary<string, long>>(); 
           
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {'\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var root = input.First().Trim();
                var properties = input.Last().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var name = properties.First().Trim();
                long size = long.Parse(properties.Last().Trim());

                  if (directories.ContainsKey(root) == false)
                    {
                        directories.Add(root, new Dictionary<string, long>());
                        
                    }
                if (directories[root].ContainsKey(name) == false)
                {
                    directories[root].Add(name, 0);
                }
                    directories[root][name] = size;
              }

            var searchedFiles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var extension = searchedFiles.First().Trim();
            var rootToSearch = searchedFiles.Last().Trim();

            bool isFound = false;

            if (directories.ContainsKey(rootToSearch))
            {
                var files = directories[rootToSearch].OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                foreach (var file in files)
                {
                    if (file.Key.Contains($".{ extension}"))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                        isFound = true;
                    }
                    
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
