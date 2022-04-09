using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(',').ToList();
            List<string> even = new List<string>();
            List<string> odd = new List<string> ();
            List<string> even15 = new List<string>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[nums[i].Length - 1].EndsWith("5") || nums[nums[i].Length - 1].EndsWith("7"))
                {
                    even.Add(nums[i]);
                }
                if (nums[nums[i].Length - 1].EndsWith("4") || nums[nums[i].Length - 1].EndsWith("8"))
                {
                    odd.Add(nums[i]);
                }
                if (nums[nums[i].Length] == "15")
                {
                    even15.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(", ", even));
            Console.WriteLine(string.Join(", ", odd));
            Console.WriteLine(string.Join(", ", even15));

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
