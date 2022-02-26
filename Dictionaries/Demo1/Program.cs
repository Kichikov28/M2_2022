using System;
using System.Collections.Generic;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vhod na elementi ot razlichni redove
            Dictionary<string, int> person = new Dictionary<string, int>();
            Console.Write("Sum: ");
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < sum; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                person.Add(name, age);

                if (person.ContainsKey(name))
                {
                    person[name] = person[name]+age;
                }
                else
                {
                    person.Add(name, age);
                }

            }
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
