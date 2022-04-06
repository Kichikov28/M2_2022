using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> number = new Dictionary<string, string>();
            while (true)
            {
                List<string> line = Console.ReadLine().Split(' ').ToList();
                if (line[0]=="End")
                {
                    break;
                }
                if (line[0]=="A")
                {
                    string name = line[1];
                    string phone = line[2];
                    if (number.ContainsKey(name))
                    {
                        number[name] = phone;
                    }
                    else
                    {
                        number.Add(name, phone);

                    }
                }
                if (line[0]=="S")
                {
                    string name = line[1];
                    if (number.ContainsKey(name))
                    {
                        Console.WriteLine($"{name}=>{number[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not exist");
                    }
                }
            }
        }
    }
}
