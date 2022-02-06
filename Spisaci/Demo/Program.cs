using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"nums[{i}]=");
                nums.Add(int.Parse(Console.ReadLine()));
            }
            nums.Add(1000);
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine("******************");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("===================");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


        }
    }
}
