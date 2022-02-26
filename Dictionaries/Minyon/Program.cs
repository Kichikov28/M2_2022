using System;
using System.Collections.Generic;
using System.Linq;

namespace Minyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minyon = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                string resource = line[0];

                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(line[1]);
                if (minyon.ContainsKey(resource))
                {
                    minyon[resource] += quantity;

                }
                else
                {
                    minyon.Add(resource, quantity);
                }
            }
            minyon = minyon.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in minyon)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
