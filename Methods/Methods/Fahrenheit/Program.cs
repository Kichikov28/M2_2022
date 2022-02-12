using System;

namespace Fahrenheit
{
    class Program
    {
        static double far(double n)
        {
            double celsium = (n - 32) * 5 / 9;
            return celsium;
        }
        static void Main(string[] args)
        {
            double celsii = far(double.Parse(Console.ReadLine()));
            Console.WriteLine($"{celsii:f2}");

        }
    }
}
