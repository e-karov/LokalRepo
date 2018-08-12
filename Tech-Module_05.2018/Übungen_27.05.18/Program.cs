using System;
using System.Numerics;

namespace Übungen_27._05._18
{
    class Program
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i'
                || symbol == 'o' || symbol == 'u' || symbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= 48 && symbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else 
            {
                Console.WriteLine("other");
            }
        }
    }
}
