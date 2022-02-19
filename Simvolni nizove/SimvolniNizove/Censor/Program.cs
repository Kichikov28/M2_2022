using System;

namespace Censor
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            foreach (var item in text)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word,new string('*', word.Length));
                }

            }
            Console.WriteLine(text);
        }
    }
}
