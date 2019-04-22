using System;

namespace _03_Extract_File
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("\\");
            string[] fileData = input[input.Length - 1].Split(".");
            string fileName = fileData[0];
            string extension = fileData[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
