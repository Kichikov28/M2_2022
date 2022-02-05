using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}]=");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("************");
            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine("=============");
            for (int i = 0; i < num.Length; i++)
            {
                if (i != 0 && i % 2 == 0)
                {
                    Console.WriteLine($"num[{i}]={num[i]}");
                }

            }
            Console.WriteLine("------------------");
            foreach (var item in num)
            {
                Console.WriteLine(num);
            }

        }
    }
}
