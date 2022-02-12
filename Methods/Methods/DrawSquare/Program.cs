using System;

namespace DrawSquare
{
    class Program
    {
        static void printHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void printmiddle(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.Write("-");
                Console.WriteLine();
            }
        }
        
        static void printAll(int n)
        {
            printHeader(n);
            printmiddle(n);
            printHeader(n);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printAll(n);

            
        }
    }
}

