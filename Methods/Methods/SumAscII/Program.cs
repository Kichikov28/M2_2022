using System;

namespace SumAscII
{
    class Program
    {
        static int GetSum(string type)
        {
            int sum = 0;
            for (int i = 0; i < type.Length; i++)
            {
                sum += type[i];


            }
            return sum;

        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int sum1 = GetSum(type);
            Console.WriteLine(sum1);

        }
    }
}
