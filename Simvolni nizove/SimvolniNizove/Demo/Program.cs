using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Word: ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"word[{i}]=>{word[i]}");
            }

        }
    }
}
