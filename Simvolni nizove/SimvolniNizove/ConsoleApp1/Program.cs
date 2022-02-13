using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hamurapi@abv.bg";
            int firstIndex = str.IndexOf("a",4);
            Console.WriteLine(firstIndex);

            int secondIndex = str.IndexOf("r");
            Console.WriteLine(secondIndex);


        }
    }
}
