using System;
using System.Collections.Generic;
using System.Linq;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> oddwords = new Dictionary<string, int>();
            var line = Console.ReadLine().ToLower().Split(' ').ToList();
            foreach (var item in line)
            {
                if (oddwords.ContainsKey(item))
                {
                    oddwords[item] += 1;
                }
                else
                {
                    oddwords[item] = 1;
                }
            }

            foreach (var item in oddwords)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key}, ");
                }
                
            }

        }
    }
}
