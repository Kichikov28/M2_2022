using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            Dictionary <string, int> person = new Dictionary<string, int>();

            num.Add(11);
            num.Add(22);
            //num[2] = 33;
            Console.WriteLine(string.Join(" ",num));

            person.Add("Ivan", 26);
            person.Add("Peter", 34);
            person["Asen"] = 25;
            Console.WriteLine(string.Join(" ",person));

            //Печат само на ключ.
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}");
            }
            Console.WriteLine();
            foreach (var item in person.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            int s = 0;

            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
                s += item.Value;
                Console.WriteLine(s);
            }
        }
    }
}
