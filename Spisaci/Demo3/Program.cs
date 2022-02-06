using System;
using System.Collections.Generic;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new list<int>() { 11, -2, 3, 11, 4, -5, 11, -6, 11 };
            Console.WriteLine(string.Join(" ", nums));
            nums.Remove(11);
            Console.WriteLine(string.Join(" ",nums));
            while (nums.Contains(11))
            {
                nums.Remove(11);
              
                
            }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
