using System;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            float metres = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float min = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float time = hours * 3600 + min * 60 + seconds;
            float ms = metres / time;
            Console.WriteLine(Math.Round(ms,6));

            float km = metres / 1000.0f;
            float chas = time / 3600f;
            Console.WriteLine(Math.Round(km/chas,6));

            float mile = metres / 1609.0f;
            Console.WriteLine(Math.Round(mile/chas,6));

        }
    }
}
