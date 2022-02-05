using System;
using System.Linq;

namespace InsertingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[array.Length + 1];
            int placed = 0;

            array = array.OrderBy(x => x).ToArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (n >= array[i - placed] || placed == 1)
                {
                    b[i] = array[i - placed];
                }
                else
                {
                    b[i] = n;
                    placed = 1;

                }
            }
            Console.WriteLine(string.Join(" ",b));
        }
    }
}
