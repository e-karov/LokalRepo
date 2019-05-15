using System;

namespace Bonus_System                      // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double courseLectures = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double maxAttendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendances = int.Parse(Console.ReadLine());

                double totalBonus = (attendances / courseLectures * (5 + additionalBonus));

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendances = attendances;
                }
            }

            Console.WriteLine($"The maximum bonus score for this course is {Math.Ceiling(maxBonus)}.The student has attended {maxAttendances} lectures.");
        }
    }
}
