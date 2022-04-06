using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>() { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };
            //Console.WriteLine($"Max=>{number.Max()}");
            //Console.WriteLine($"Min=>{number.Min()}");
            //Console.WriteLine($"Sum=>{number.Sum()}");
            //Console.WriteLine($"Sum=>{number.Average():f2}");
            Console.WriteLine(string.Join(" ",number));
            number = number.Distinct().ToList();
            Console.WriteLine(string.Join(" ",number));


            //number = number.Select(x => x+10).ToList();
            //Console.WriteLine(string.Join(" ",number));




            //number = number.Where(x => x % 2 == 0).Where(x=>x<7).ToList();
            //Console.WriteLine(string.Join(" ",number));
            //number = number.Where(x => x % 3 == 0).ToList();
            //Console.WriteLine(string.Join(" ",number));
            //int devby3 = number.Count(x => x % 3 == 0);
            //Console.WriteLine($"{devby3}");

            //number = number.OrderByDescending(x => x).Take(3).ToList();
            //Console.WriteLine(String.Join(" ",number));
            //Console.WriteLine($"Sum=>{number.Sum()}");


        }
    }
}
