using System;

namespace BiggerNumber
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            if (type=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            if (type=="char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char max = GetMax(a, b);
                Console.WriteLine(max);
            }
            if (type=="string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
            

        }
    }
}
