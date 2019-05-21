using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MeTube_Statistics                 // 100 / 100
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> videos = new Dictionary<string, int>();
            Dictionary<string, int> rating = new Dictionary<string, int>();
            
            string inputLine = Console.ReadLine();

            while (true)
            {
                if (inputLine == "stats time")
                {
                    break;
                }

                if (inputLine.Contains('-'))
                {
                    string[] video = inputLine.Split('-');
                    string name = video[0];
                    int views = int.Parse(video[1]);

                    if (videos.ContainsKey(name) == false)
                    {
                        videos.Add(name, 0);
                        rating.Add(name, 0);
                    }
                    videos[name] += views;
                }

                else if (inputLine.Contains(':'))
                {
                    string[] votes = inputLine.Split(':');
                    string vote = votes[0];
                    string name = votes[1];

                    if (rating.ContainsKey(name))
                    {
                        if (vote == "like")
                        {
                            rating[name] += 1;
                        }

                        else if (vote == "dislike")
                        {
                            rating[name] -= 1;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            if (inputLine == "by views")
            {
                foreach (var name in videos.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"{name.Key} - {name.Value} views - {rating[name.Key]} likes");
                }
                
            }
            else if (inputLine == "by likes")
            {
                foreach (var name in rating.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"{name.Key} - {videos[name.Key]} views - {name.Value} likes");
                }
            }
        }
    }
}
