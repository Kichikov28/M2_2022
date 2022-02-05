using System;
using System.Linq;

namespace SearchingAnElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            arr = arr.OrderBy(x => x).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (n == arr[i])
                {
                    Console.WriteLine("Yes");
                    
                }
                else
                {
                    Console.WriteLine("No");
                    
                }
                break;
            }
        }
    }
}
