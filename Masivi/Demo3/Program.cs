using System;
using System.Linq;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(string.Join("; ",num));
        }
    }
}
