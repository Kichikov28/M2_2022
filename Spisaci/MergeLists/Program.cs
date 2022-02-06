using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split('|').ToList();

            List<int> result = new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                List<string> nums=list[i].Split(' ').ToList();
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[j] != "")
                    {
                        result.Add(int.Parse(nums[j]));
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", result));



        }
    }
}
