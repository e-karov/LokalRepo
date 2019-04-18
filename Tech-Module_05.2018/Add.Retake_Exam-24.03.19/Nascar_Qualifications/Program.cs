using System;
using System.Collections.Generic;
using System.Linq;

namespace Nascar_Qualifications                 // 100 / 100
{
    class Program
    {
        static void Main()
        {
            List<string> racers = Console.ReadLine().Split().ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandLine = input.Split();
                string command = commandLine[0];
                string racerName = commandLine[1];

                switch (command)
                {
                    case "Race":
                        if (racers.Contains(racerName) == false)
                        {
                            racers.Add(racerName);
                        }

                        break;

                        case "Accident":
                        if (racers.Contains(racerName))
                        {
                            racers.Remove(racerName);
                        }

                        break;

                    case "Box":
                        if (racers.Contains(racerName))
                        {
                            int index = racers.IndexOf(racerName);
                            if (index != racers.Count-1)
                            {
                                racers.RemoveAt(index);
                                racers.Insert(index + 1, racerName);
                            }
                        }


                        break;
                    case "Overtake":

                        int racersCount = int.Parse(commandLine[2]);

                        if (racers.Contains(racerName))
                        {
                            int index = racers.IndexOf(racerName);
                            int newIndex = (index - racersCount);

                            if (newIndex >= 0)
                            {
                                racers.Insert(newIndex, racerName);
                                racers.RemoveAt(index+1);
                            }
                        }

                        break;
                }

            }

            Console.WriteLine(String.Join(" ~ ", racers));
        }
    }
}
