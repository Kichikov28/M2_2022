using System;

namespace ConsoleApp1
{
    class Program
    {
        static void printNumbers(int start, int end)
        {
            for (int i = start; i <=end; i++)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            printNumbers(4, 10);
        }
    }
}
