using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new list<int>() { 11, -2, 3, 4, -5, -6, 11 };
            //Console.WriteLine(string.Join(" ", nums));

            //nums.Remove(11);
            //Console.WriteLine(string.Join(" ", nums));

            //nums.RemoveAt(0);
            //Console.WriteLine(string.Join(" ", nums));

            //nums.Insert(1, 222);
            //Console.WriteLine(string.Join(" ", nums));

            ////nums = nums.OrderBy(x => x).ToList();
            //nums.Sort();
            //Console.WriteLine(string.Join(" ", nums));

            //nums.Reverse();
            //Console.WriteLine(string.Join(" ", nums));

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastnumber = nums[nums.Count - 1];
            while (nums.Contains(lastnumber))
            {
                nums.Remove(lastnumber);
            }
            Console.WriteLine(string.Join(" ",nums));


        }
    }
}
