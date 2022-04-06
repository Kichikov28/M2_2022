using System;
using System.Collections.Generic;
using System.Linq;

namespace BasketballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> basketball = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine().Split('-').ToList();
                if (line[0]=="END")
                {
                    break;
                }
                string name = line[0];
                int points = int.Parse(line[1]); 
                if (basketball.ContainsKey(name))
                {
                    basketball[name] += points;
                }
                else
                {
                    basketball.Add(name, points);
                }
            }
            basketball = basketball.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in basketball)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
