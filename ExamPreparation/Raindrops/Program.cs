using System;
using System.Linq;
using System.Collections.Generic;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                List<double> line = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                double raindropsCountDev = line[0] / line[1];
                sum += raindropsCountDev;


            }
            sum /= density;
            Console.WriteLine($"{sum:f3}");

        }
    }
}
