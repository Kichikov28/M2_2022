using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            int max = num.Min();

            int min = num.Min();
            Console.Write(string.Join(" ", num.Where(x => x == min)));
            Console.WriteLine(string.Join(" ", num.Where(x => x == max)));
        }
    }
}
