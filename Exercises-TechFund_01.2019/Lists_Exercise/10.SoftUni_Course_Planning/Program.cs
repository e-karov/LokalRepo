using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_Course_Planning               // 100 / 100
{
    class Program
    {
        static void Main()
        {
            List<string> courses = Console.ReadLine().Split(", ").ToList();

            string commandLine = "";

            while ((commandLine = Console.ReadLine()) != "course start")
            {
                string[] commands = commandLine.Split(":");
                string action = commands[0];
                string lessonTitle = commands[1];

                switch (action)
                {
                    case "Add":

                        if (!courses.Contains(lessonTitle))
                        {
                            courses.Add(lessonTitle);
                        }
                        break;

                    case "Insert":

                        int index = int.Parse(commands[2]);
                        if ( ! courses.Contains(lessonTitle))
                        {
                            courses.Insert(index, lessonTitle);
                        }

                        break;

                    case "Remove":

                        if (courses.Contains(lessonTitle))
                        {
                            if (courses.Contains($"{lessonTitle}-Exercise"))
                            {
                                courses.Remove($"{lessonTitle}-Exercise");
                            }
                            courses.Remove(lessonTitle);
                        }
                        break;

                    case "Swap":
                        string lessonTitle2 = commands[2];
                        
                        if (courses.Contains(lessonTitle) && courses.Contains(lessonTitle2))
                        {
                            index = courses.IndexOf(lessonTitle);
                            int index2 = courses.IndexOf(lessonTitle2);

                            courses.Insert(index, lessonTitle2);
                            courses.RemoveAt(index + 1);

                            courses.Insert(index2, lessonTitle);
                            courses.RemoveAt(index2+1);

                            if (courses.Contains($"{lessonTitle2}-Exercise"))
                            {
                                courses.Remove($"{lessonTitle2}-Exercise");
                                courses.Insert(courses.IndexOf(lessonTitle2) + 1, ($"{lessonTitle2}-Exercise"));
                            }

                            if (courses.Contains($"{lessonTitle}-Exercise"))
                            {
                                courses.Remove($"{lessonTitle}-Exercise");
                                courses.Insert(courses.IndexOf(lessonTitle)+1, ($"{lessonTitle}-Exercise"));
                            }

                        }
                        break;

                    case "Exercise":

                        if ( ! courses.Contains(lessonTitle))
                        {
                            courses.Add(lessonTitle);
                            courses.Add($"{lessonTitle}-Exercise");
                        }

                        else
                        {
                            if ( ! courses.Contains($"{lessonTitle}-Exercise"))
                            {
                                index = courses.IndexOf(lessonTitle);
                            courses.Insert(index + 1, $"{lessonTitle}-Exercise");
                            }
                            
                        }
                        break;
                }
                
            }

            int num = 0;
            foreach (var course in courses)
            {
                Console.WriteLine($"{++num}.{course}");
            }

        }
    }
}
