using System;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums = nums.OrderBy(x => x).ToList();
            var counts = new int[nums.Max() + 1];

            foreach (var item in nums)
            {
                counts[item]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i}=>{counts[i]}");
                }
            }

        }
    }
}
