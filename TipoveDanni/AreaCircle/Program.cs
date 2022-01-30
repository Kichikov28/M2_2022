using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI*r*r);
        }
    }
}
