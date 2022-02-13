using System;


class Program
{
    static void Reverse(string word)
    {
        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]);
             
        }
    }
    static void Main()
    {
       
        string word = Console.ReadLine();
        Reverse(word);

    }
}

