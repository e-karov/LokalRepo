using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Array_Manipulator
{
    class Program       // 40 / 100
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "end")
            {
                string[] commands = inputLine.Split().ToArray();

                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);

                    if (index >= 0 && index < arr.Length)
                    {
                        arr = ExchangeArray(arr, index);
                    }

                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (commands[0] == "max")
                {
                    string type = commands[1];
                    if (type == "even")
                    {
                        int index = MaxEvenElementsIndex(arr);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }

                    else if (type == "odd")
                    {
                        int index = MaxOddElementsIndex(arr);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }

                else if (commands[0] == "min")
                {
                    string type = commands[1];

                    if (type == "even")
                    {
                        int index = MinEvenElementsIndex(arr);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }

                    else if (type == "odd")
                    {
                        int index = MinOddElementsIndex(arr);

                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }

                else if (commands[0] == "first")
                {
                    int count = int.Parse(commands[1]);
                    string type = commands[2];

                    PrintFirstNElements(arr, count, type);
                }

                else if (commands[0] == "last")
                {
                    int count = int.Parse(commands[1]);
                    string type = commands[2];

                    PrintLastNElements(arr, count, type);
                }
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        static int[] ExchangeArray(int[] arr, int index)
        {
            List<int> firstPart = arr.Skip(index + 1).ToList() ;
            List<int> secondPart = arr.Take(index).ToList();
            arr.C ();
            arr = newList.ToArray();
            //for (int i = 0; i <= index; i++)
            //{
            //    int firstNum = arr[0];

            //    for (int j = 0; j < arr.Length - 1; j++)
            //    {
            //        arr[j] = arr[j + 1];
            //    }

            //    arr[arr.Length - 1] = firstNum;
        
            return arr;
        }

        static int MaxEvenElementsIndex(int[] arr)
        {
            int maxElement = int.MinValue;
            int maxElemtnsIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= maxElement)
                {
                    maxElement = arr[i];
                    maxElemtnsIndex = i;
                }
            }
            return maxElemtnsIndex;
        }

        static int MaxOddElementsIndex(int[] arr)
        {
            int maxElement = int.MinValue;
            int maxElemtnsIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] >= maxElement)
                {
                    maxElement = arr[i];
                    maxElemtnsIndex = i;
                }
            }
            return maxElemtnsIndex;
        }

        static int MinEvenElementsIndex(int[] arr)
        {
            int minElement = int.MaxValue;
            int minElemtnsIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] <= minElement)
                {
                    minElement = arr[i];
                    minElemtnsIndex = i;
                }
            }
            return minElemtnsIndex;
        }

        static int MinOddElementsIndex(int[] arr)
        {
            int minElement = int.MaxValue;
            int minElementsIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] <= minElement)
                {
                    minElement = arr[i];
                    minElementsIndex = i;
                }
            }
            return minElementsIndex;
        }

        static void PrintFirstNElements(int[] arr, int count, string type)
        {
            if (count > arr.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;

            if (type == "odd")
            {
                List<int> oddElements = new List<int>();

                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] % 2 != 0)
                    {
                        counter++;
                        oddElements.Add(arr[i]);
                    }

                    if (counter == count)
                    {
                        break;
                    }
                }
                Console.WriteLine("[" + String.Join(", ", oddElements) + "]");
            }

            else if (type == "even")
            {
                counter = 0;
                List<int> evenElements = new List<int>();

                for (int i = 0; i < counter; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        counter++;
                        evenElements.Add(arr[i]);

                        if (counter == count)
                        {
                            break;
                        }
                    }

                }
                Console.WriteLine("[" + String.Join(", ", evenElements) + "]");
            }
        }

        static void PrintLastNElements(int[] arr, int count, string type)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;

            if (type == "odd")
            {
                List<int> oddElements = new List<int>();

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        counter++;
                        oddElements.Add(arr[i]);

                        if (counter == count)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("[" + String.Join(", ", oddElements));

            }


            else if (type == "even")
            {
                counter = 0;
                List<int> evenElements = new List<int>();
                string output = String.Format("[" + String.Join(", ", evenElements) + "]");

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        counter++;
                        evenElements.Add(arr[i]);

                        if (counter == count)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine(output);

            }


        }
    }
}
