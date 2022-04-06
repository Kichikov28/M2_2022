using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> football = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine().Split('-').ToList();
                if (line[0]=="End of season")
                {
                    break;
                }
                string name = line[0];
                int goals = int.Parse(line[1]);
                if (football.ContainsKey(name))
                {
                    football[name] += goals;
                }
                else
                {
                    football.Add(name, goals);
                }
                
            }
            foreach (var item in football)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
