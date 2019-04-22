using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Array_Manipulator_2
{
    class Program           // 70/100 points
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] inputLine = Console.ReadLine().Split();
            List<int> exchanged = new List<int>();

            while (inputLine[0] != "end")
            {
                string command = inputLine[0].ToLower();

                if (command == "exchange")
                {
                    int index = int.Parse(inputLine[1]);
                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    exchanged =  numbers.Skip(index +1).Take(numbers.Count - index).ToList();
                    exchanged.AddRange(numbers.Take(index + 1));
                    numbers = exchanged;
                }

                else if(command == "max")
                {
                    if (inputLine[1] == "even")
                    {
                        try
                        {
                            int maxIndex = numbers.LastIndexOf(numbers.Where(x => x % 2 == 0).Max());
                            Console.WriteLine(maxIndex);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("No matches"); ;
                        }
                       
                    }
                    else if (inputLine[1] == "odd")
                    {
                        try
                        {
                            int maxIndex = numbers.LastIndexOf(numbers.Where(x => x % 2 != 0).Max());
                            Console.WriteLine(maxIndex);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("No matches"); ;
                        }
                        
                    }
                }

                else if (command == "min")
                {
                    if (inputLine[1] == "even")
                    {
                        try
                        {
                            int minIndex = numbers.LastIndexOf(numbers.Where(x => x % 2 == 0).Min());
                            Console.WriteLine(minIndex);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("No matches"); ;
                        }

                       
                    }
                    else if (inputLine[1] == "odd")
                    {
                        try
                        {
                            int minIndex = numbers.LastIndexOf(numbers.Where(x => x % 2 != 0).Min());
                            Console.WriteLine(minIndex);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("No matches"); ;
                        }

                    }
                }

                else if (command == "first")
                {
                    int count = int.Parse(inputLine[1]);
                    string type = inputLine[2];

                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                        
                    }
                    
                    else if (type == "odd")
                    {
                        int[] result = numbers.Where(x => x % 2 != 0).Take(count).ToArray();
                        Console.WriteLine("[" + string.Join(", ", result) + "]");
                    }
                    else if (type == "even")
                    {
                        int[] result = numbers.Where(x => x % 2 == 0).Take(count).ToArray();
                        Console.WriteLine("[" + string.Join(", ", result
                            ) + "]");
                    }
                }

                else if (command == "last")
                {
                    int count = int.Parse(inputLine[1]);
                    string type = inputLine[2];

                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }

                    else if (type == "odd")
                    {
                        int[] result = numbers.Where(x => x % 2 != 0).Reverse().Take(count).ToArray() ;
                        Console.WriteLine("[" + string.Join(", ", result) + "]");
                    }
                    else if (type == "even")
                    {
                        int[] result = numbers.Where(x => x % 2 == 0).Reverse().Take(count).ToArray();
                        Console.WriteLine("[" + string.Join(", ", result) + "]");
                        
                    }
                }



                inputLine = Console.ReadLine().Split();
            }

            Console.WriteLine("["+ string.Join(", ", numbers) + "]");
        }
    }
}
