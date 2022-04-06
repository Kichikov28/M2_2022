using System;
using System.Linq;

namespace SortShortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] { ',', '!', ' ', '!', '.' };
            var input = Console.ReadLine().Split(separators).Select(x => x.ToLower()).ToList();
            input = input.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(string.Join(" ",input));

        }
    }
}
