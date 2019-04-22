using System;

namespace _06.String_Explosion              // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i+1].ToString());
                    
                }
                else
                {
                    if (strength > 0)
                    {
                        input = input.Remove(i, 1);
                        strength--;
                        i--;
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
