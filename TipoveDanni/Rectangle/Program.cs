using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double p = 2 * (a + b);
            double s = a * b;
            double d = Math.Sqrt(a*a + b*b);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }
    }
}
