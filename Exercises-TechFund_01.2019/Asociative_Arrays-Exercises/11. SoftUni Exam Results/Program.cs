using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results             // 100 / 100
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = "";

            while ((input = Console.ReadLine() )!= "exam finished")
            {
                string[] inputLine = input.Split("-");
                string student = inputLine[0];

                if (inputLine[1] == "banned")
                {
                    participants.Remove(student);
                    continue;
                }

                string language = inputLine[1];
                int points =int.Parse( inputLine[2]);

                if (participants.ContainsKey(student) == false)
                {
                    participants.Add(student, 0);
                }
                if (points > participants[student])
                {
                    participants[student] = points;
                }

                if (submissions.ContainsKey(language) == false)
                {
                    submissions.Add(language, 0);
                }
                submissions[language]++;
            }

            Console.WriteLine("Results:");
            foreach (var kvp in participants.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var lang in submissions.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
