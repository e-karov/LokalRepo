using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Anonymous_Cache
{
    class Program
    {
        public static object Di { get; private set; }

        static void Main()
        {
           
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string dataSet = "";
                string dataKey = "";
                long dataSize = 0;
                string command = input[0];

                if (command == "thetinggoesskrra")
                {
                    break;
                }

                if (input.Length == 1)
                {
                    dataSet = input[0];

                    if (data.ContainsKey(dataSet) == false)
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }
                    if (cache.ContainsKey(dataSet))
                    {
                        data[dataSet] = cache[dataSet];
                        cache.Remove(dataSet);
                    }

                }
                else
                {
                    dataKey = input[0];
                    dataSize = long.Parse(input[2]);
                    dataSet = input[4];

                    if (data.ContainsKey(dataSet))
                    {
                        if (data[dataSet].ContainsKey(dataKey) == false)
                        {
                            data[dataSet].Add(dataKey, 0);
                        }
                        data[dataSet][dataKey] = dataSize;
                    }
                    else
                    {
                        if (cache.ContainsKey(dataSet) == false)
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                            if (cache[dataSet].ContainsKey(dataKey) == false)
                            {
                                cache[dataSet].Add(dataKey, 0);
                            }
                            cache[dataSet][dataKey] = dataSize;
                        }
                        else
                        {
                            cache[dataSet][dataKey] = dataSize;
                        }
                    }
                }

                
            }

            if (data.Count > 0)
            {
                KeyValuePair<string, Dictionary<string, long>> maxSizeData
               = data.OrderByDescending(ds => ds.Value.Sum(d => d.Value)).First();

                Console.WriteLine($"Data Set: {maxSizeData.Key}, Total Size: {maxSizeData.Value.Sum(d => d.Value)}");

                foreach (var ds in maxSizeData.Value)
                {
                    Console.WriteLine($"$.{ds.Key}");
                }
            }

            
        }
    }
}
