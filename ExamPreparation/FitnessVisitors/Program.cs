using System;
using System.Linq;

namespace FitnessVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            var visitors = Console.ReadLine().Split(',').ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }
                if (command== "Add visitor")
                {
                    string name = Console.ReadLine();
                    visitors.Add(name);
                }
                if (command== "Add visitor on position")
                {
                    string name = Console.ReadLine();
                    int pos = int.Parse(Console.ReadLine());
                    visitors.Insert(pos, name);
                }
                if (command == "Remove visitor on position")
                {
                    int pos = int.Parse(Console.ReadLine());
                    visitors.RemoveAt(pos);
                }
                if (command == "Remove last visitor")
                {
                    visitors.RemoveAt(visitors.Count - 1);
                }
                if (command == "Remove first visitor")
                {
                    visitors.RemoveAt(0);

                }

            }
            Console.WriteLine(string.Join(", ",visitors));
        }
    }
}
