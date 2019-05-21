using System;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main()
        {
            string lines = "";

            for (int i = 0; i < 5; i++)
            {
                lines += Console.ReadLine() +"\n";
            }

            Match match = Regex.Match(lines, @"^([^a-zA-Z0-9]+)\n([0-9_]+)([^a-zA-Z0-9]+)([\d_]+)(?<coreText>[a-zA-Z]+)([\d_]+)([^a-zA-Z0-9]+)\n([0-9_]+)\n([^a-zA-Z0-9]+)$");

            if (match.Success)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(match.Groups["coreText"].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            //string surface = Console.ReadLine();
            //string mantle = Console.ReadLine();
            //string core = Console.ReadLine();
            //string mantle2 = Console.ReadLine();
            //string surface2 = Console.ReadLine();

            //Match surfaceMatch = Regex.Match(surface, @"^([^a-zA-Z0-9]+)$");
            //Match surface2Match = Regex.Match(surface2, @"^([^a-zA-Z0-9]+)$");

            //if (surfaceMatch.Success && surface2Match.Success)
            //{
            //    Match mantleMatch = Regex.Match(mantle, @"^(^[\d_]+)$");
            //    Match mantle2Match = Regex.Match(mantle2, @"^(^[\d_]+)$");

            //    if (mantleMatch.Success && mantle2Match.Success)
            //    {
            //        Match coreMatch = Regex.Match(core, @"(^[^a-zA-Z0-9]+)([\d_]+)(?<coreText>[a-zA-Z]+)([\d_]+)([^a-zA-Z0-9]+)$");

            //        if (coreMatch.Success)
            //        {
            //            Console.WriteLine("Valid");
            //            Console.WriteLine(coreMatch.Groups["coreText"].Length);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid"); ;
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
        }
    }
}
