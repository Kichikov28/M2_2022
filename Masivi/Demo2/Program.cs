using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("day: ");
            int day = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i =0; i < days.Length; i++)
            {
                if (day==(i+1))
                {
                    Console.WriteLine(days[i]);
                }
                
            }
            
        }
    }
}
