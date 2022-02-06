using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> num = Console.ReadLine().Split(',').ToList();
            foreach (var item in num)
            {
                
                Console.WriteLine(string.Join(" ",item.Split(' ').Reverse()));
            }

        }
    }
}
