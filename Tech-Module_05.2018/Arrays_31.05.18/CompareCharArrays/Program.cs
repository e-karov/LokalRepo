using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstLine = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondLine = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int min = Math.Min(firstLine.Length, secondLine.Length);

            if (firstLine.Length == secondLine.Length)
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    if (firstLine[i] > secondLine[i])
                    {
                        Console.WriteLine(string.Join("", secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        break;

                    }
                }
            }
            else
            {
                for (int i = 0; i < min; i++)
                {
                    if (firstLine.Length > secondLine.Length)
                    {
                        if (firstLine[i] == secondLine[i])
                        {
                            Console.WriteLine(string.Join("", secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                           
                            break;
                        }
                        else if (firstLine[i] > secondLine[i])
                        {
                            Console.WriteLine(string.Join("", secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", firstLine));
                            Console.WriteLine(string.Join("", secondLine));
                            break;
                        }
                    }
                    else if (firstLine.Length < secondLine.Length)
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        break;

                    }



                }
            }
        }
    }
}
