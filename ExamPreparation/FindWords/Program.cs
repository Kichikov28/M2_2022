using System;
using System.Collections.Generic;
using System.Linq;

namespace FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> specials = new List<string> { };
            List<string> others = new List<string> { };

            for (int i = 0; i < n; i++)
            {
                string words = Console.ReadLine();
                
                if (words[0] >= 'A' && words[0] <= 'Z' &&(words.Contains('i')||words.Contains('I')) && words.Length > 7)
                {
                    specials.Add(words);
                }
                else
                {
                    others.Add(words);
                }

            }
            Console.WriteLine($"Special words: {string.Join(", ",specials)}");
            Console.WriteLine();
            Console.WriteLine($"Special words: {string.Join(", ", others)}");







        }

       
    }
}
