using System;
using System.Linq;

namespace _10.LadyBugs      // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int[] indexArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < indexArr.Length; i++)
            {
                if (indexArr[i] >= 0 && indexArr[i] < arr.Length)
                {
                    arr[indexArr[i]] = 1;
                }
            }

            string commandLine = "";
            while ((commandLine = Console.ReadLine()) != "end")
            {
                string[] commands = commandLine.Split();
                int startIndex = int.Parse(commands[0]);
                string command = commands[1];
                int len = int.Parse(commands[2]);

                
                if (startIndex < 0 || startIndex > arr.Length - 1)
                {
                    continue;
                }
                if (arr[startIndex] == 0)
                {
                    continue;
                }

                arr[startIndex] = 0;
                bool isTargetValid = false;

                while (isTargetValid != true)
                {
                    int targetIndex = 0;

                    if (command == "right")
                    {
                        targetIndex = startIndex + len;
                        if (targetIndex < 0 || targetIndex > arr.Length - 1)
                        {
                            break;
                        }

                    }
                    else if (command == "left")
                    {
                        targetIndex = startIndex - len;
                        if (targetIndex < 0 || targetIndex > arr.Length - 1)
                        {
                            break;
                        }
                    }

                    if (targetIndex >= 0 && targetIndex < arr.Length)
                    {
                        if (arr[targetIndex] == 0)
                        {
                            isTargetValid = true;
                            arr[targetIndex] = 1;

                        }
                        else if (arr[targetIndex] != 0)
                        {
                            startIndex = targetIndex;
                        }

                    }

                }

            }

            Console.WriteLine(string.Join(' ', arr));



        }
    }
}
