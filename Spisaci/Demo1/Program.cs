using System;
using System.Collections.Generic;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 2, 3, 4, 5, 11 };
            List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            days.Add("Saturday");
            days.Add("Sunday");
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine(days[i]);
            }
            Console.WriteLine(string.Join(" ",days));
            Console.WriteLine(days[2]);
        }
    }
}
