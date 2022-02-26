using System;
using System.Collections.Generic;
using System.Linq;

namespace RealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            var line = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            foreach (var item in line)
            {
                if (numbers.ContainsKey(item))
                {
                    numbers[item] += 1;
                }
                else
                {
                    numbers[item] = 1;
                }
            }
            numbers = numbers.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in numbers)
            {
               Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
