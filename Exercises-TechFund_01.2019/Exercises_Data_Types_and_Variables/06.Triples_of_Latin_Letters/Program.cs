using System;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int startIndex = 97;
            int endIndex = 97 + n;

            for (int i = startIndex; i < endIndex; i++)
            {
                
                for (int j = startIndex; j < endIndex; j++)
                {
                 
                    for (int k = startIndex; k < endIndex; k++)
                    {
                        Console.Write((char)i);
                        Console.Write((char)j);
                        Console.Write((char)k);
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
