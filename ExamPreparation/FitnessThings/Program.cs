using System;

namespace FitnessThings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                if (product== "treadmill")
                {
                    sum += 5899;
                }
                else if (product== "cross trainer")
                {
                    sum += 1699;
                }
                else if (product == "exercise bike")
                {
                    sum += 1789;
                }
                else if (product == "dumbbells")
                {
                    sum += 579;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
