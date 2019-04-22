using System;

namespace _02.Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string strA = input[0];
            string strB = input[1];
            int sum = MultplyChars(strA, strB);

            Console.WriteLine(sum);
        }

        static int MultplyChars(string a, string b)
        {
            int sum = 0;
            string shorterStr = "";
            string longerStr = "";

            if (a.Length <= b.Length)
            {
                shorterStr = a;
                longerStr = b;
            }
            else
            {
                shorterStr = b;
                longerStr = a;
            }

            for (int i = 0; i < shorterStr.Length; i++)
            {
                sum += (int)a[i] * (int)b[i];
            }

            for (int k = shorterStr.Length; k < longerStr.Length; k++)
            {
                sum += (int)longerStr[k];
            }
            return sum;
        }
    }
}
