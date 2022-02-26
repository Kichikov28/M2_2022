using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                if (line[0] == "END")
                {
                    break;
                }

                if (line[0] == "A")
                {
                    string name = line[1];
                    string number = line[2];

                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = number;
                    }
                    else
                    {
                        phonebook.Add(name, number);
                    }
                    phonebook[name] = number;
                }
                if (line[0] == "S")
                {
                    string namePechat = line[1];
                    if (phonebook.ContainsKey(namePechat))
                    {
                        Console.WriteLine($"{namePechat} => {phonebook[namePechat]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {namePechat} dows not exist.");
                    }
                }
                if (line[0] == "Print")
                {
                    Console.WriteLine("=======================");
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} => {item.Value}");
                    }
                }
            }
        }
    }
}
