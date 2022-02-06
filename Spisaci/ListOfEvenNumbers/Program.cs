using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            
            foreach (var item in num)
            {
                if (num[item] % 2 == 0)
                {
                    Console.WriteLine(num[i] + " ");
                }
            }
        }
    }
}
