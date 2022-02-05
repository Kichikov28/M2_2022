using System;

namespace Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int broi = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine($"{(char)('a'+i)}{(char)('a'+j)}{(char)('a'+k)}");
                        broi++;
                    }
                }
            }
            Console.WriteLine(broi);
            
        }
    }
}
