using System;

namespace _03.Characters_in_Range
{
    class Program
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char[] range = GetCharsInRange(a, b);
            PrintCharsRange(range);
        }

        private static void PrintCharsRange(char [] range)
        {
            Console.WriteLine(string.Join(' ', range));
        }

        static char[] GetCharsInRange(char a, char b)
        {
            char[] charsRange = new char[Math.Abs(a - b)-1];
            int index = 0;
            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            for (int i = ++start; i < end; i++)
            {
                charsRange[index++] = (char)i;
            }

            return charsRange;
        }
    }
}
