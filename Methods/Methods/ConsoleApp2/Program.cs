using System;

namespace ConsoleApp2
{
    class Program
    {
        static int SumAll(int n)
        {
            n = Math.Abs(n);
            int sumEven = 0;
            int sumOdd = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    sumEven += n % 10;
                }
                else
                {
                    sumOdd+= n % 10;
                }
                n /= 10;
            }
            
            return sumEven*sumOdd;
            


        }
        static int Sum(int n)
        {
            n = Math.Abs(n);
            return SumEven(n) * SumOdd(n);
        }
        static int SumEven(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    sum += n % 10;
                }
                n /= 10;
            }
            return sum;
        }
        static int SumOdd(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 != 0)
                {
                    sum += n % 10;
                }
                n /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //n = Math.Abs(n);
            //int Even = SumEven(n);
            //int Odd = SumOdd(n);

            //Console.WriteLine(Sum(n));
            Console.WriteLine(SumAll(n));

        }
    }
}

