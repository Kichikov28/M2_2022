using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };
            var chisla = new int[] { 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(string.Join("; ", numbers));
        }
    }
}
