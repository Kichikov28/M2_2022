using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= num; i++)
            {
                int SumOfDigits = 0;
                int digits = i;
                while (digits>0)
                {
                    SumOfDigits += digits%10;
                    digits /= 10;

                }
                if (SumOfDigits==5||SumOfDigits==7||SumOfDigits==11)
                {
                    Console.WriteLine($"{i}->true");
                }
                else
                {
                    Console.WriteLine($"{i}->false");
                }

                

            }

        }
    }
}
