using System;

namespace Demo2
{
    class Program
    {
        static void AddOne(int a)
        {
            a++;
            Console.WriteLine(a);
        }
        static int PlusOne(int a)
        {
            a++;
           return a;
        }
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //AddOne(number)
            
            int plusone=PlusOne(int.Parse(Console.ReadLine()));
            Console.WriteLine(plusone);
        }
    }
}
