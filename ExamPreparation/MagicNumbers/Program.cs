using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(',').ToList();
            List<int> even = new List<int> { };
            List<int> odd = new List<int> { };

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[nums[i].Length - 1]= 8 || nums[nums[i].Length - 1] = 4)
                {

                }
            }

            //foreach (var item in nums)
            //{
            //    if (nums[item]%5==0)
            //    {
            //        Console.WriteLine(nums[item]+"");
            //    }
            //}
        }
    }
}
