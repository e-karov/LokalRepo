using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses           // 100/100
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input  != "end")
            {
                string[] courseInfo = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string courseName = courseInfo[0];
                string student = courseInfo[1];

                if (courses.ContainsKey(courseName) == false)
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(student);

                input = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(c => c.Value.Count()))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");

                foreach (var student in course.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
