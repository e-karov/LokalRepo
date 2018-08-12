using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            //alternative:

            //string word = Console.ReadLine();

            //foreach(char letter in word)
            //{
            //    int index = letter - 97;

            //    Console.WriteLine($"{letter} -> {index}");
            //}

            string word = Console.ReadLine();
            char[] alphabet = new char[26];

            int index = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[index++] = i;
            }

            foreach (char letter in word)
            {
                int foundindex = IndexOf(alphabet, letter);
                Console.WriteLine($"{letter} -> {foundindex}");
            }

           
        }
        private static int IndexOf(char[] alphabet, char letter)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
