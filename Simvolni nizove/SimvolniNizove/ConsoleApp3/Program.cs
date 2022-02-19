using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "   Asen Ivanov uchitel na 33 godini!";
            Console.WriteLine(words);
            words = words.Trim(',', ' ', '!');
            Console.WriteLine(words);
        }
    }
}
