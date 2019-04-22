using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Company_Users             // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input;
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End" )
            {
                string[] inputLine = input.Split(" -> ").ToArray();
                string company = inputLine[0];
                string id = inputLine[1];

                if (companies.ContainsKey(company) == false)
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                }

                else if (companies[company].Contains(id) == false)
                {
                    companies[company].Add(id);
                }
             
            }

            foreach (var company in companies.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{ company.Key}");

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }



        }
    }
}
