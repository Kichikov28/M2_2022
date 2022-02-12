using System;

namespace AreaTriangle
{
    class Program
    {
        static double area(double a, double ha)
        {
            double area = a * ha / 2;
            return area;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            Console.WriteLine(area(a,ha));

        }
    }
}
