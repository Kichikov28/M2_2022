using System;

namespace WordsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int maxS = 0;
            string maxWord=string.Empty;
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "END OF GAME")
                {
                    break;
                }
                for (int i = 0; i < word.Length; i++)
                {
                    s += (int)word[i];
                }
                if (word[0] > 'A' && word[0] <= 'Z')
                {
                    s += 15;
                }
                if (word[word.Length-1]=='t')
                {
                    s += 20;
                }
                if (word.Length>=10)
                {
                    s += 30;
                }
                if (maxS<s)
                {
                    maxS = s;
                   maxWord = word;
                }
                s = 0;
            }
            Console.WriteLine($"Winner is word: {maxWord}");
            Console.WriteLine($"Points: {maxS}");
        }
    }
}
