using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> football = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine().Split('-').ToList();
                string command = line[0];

                if (command == "End of season")
                {
                    break;
                }
                int goals = int.Parse(line[1]);
                if (football.ContainsKey(command))
                {
                    football[command] += goals;
                }
                else
                {
                    football.Add(command, goals);
                }

            }
            football = football.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in football)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
