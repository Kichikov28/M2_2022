using System;
using System.Linq;

namespace StatisticsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"Min={num.Min()}");
            Console.WriteLine($"Max={num.Max()}");
            Console.WriteLine($"Sum={num.Sum()}");
            Console.WriteLine($"Average={num.Average()}");

            //Console.WriteLine(num.Min());
            //int min = int.MaxValue;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (min>num[i])
            //    {
            //        min = num[i];
            //    }
            //}
            //Console.WriteLine($"Min={min}");
        }
    }
}
