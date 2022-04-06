using System;

namespace SpringClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string clothes = Console.ReadLine();
                if (clothes== "t-shirt")
                {
                    sum += 20;
                }
                else if (clothes=="jeans")
                {
                    sum += 50;
                }
                else if (clothes== "trainers")
                {
                    sum += 70;
                }
                else if (clothes== "jacket")
                {
                    sum += 60;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
