using System;

namespace Powing
{
    class Program
    {
        static double sum(double num, double n)
        {
            double a=1;
            for (int i = 0; i < n; i++)
            {
                a*=num;
            }
            return a;
            //double sum = Math.Pow(num, n);
            
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(sum(num,n));
        }
    }
}
