using System;

namespace IndexOfLetter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {word[i]-97}");
            }
        }
    }
}
