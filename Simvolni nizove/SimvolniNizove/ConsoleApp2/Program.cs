using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string coctail = "Vodka + Martini + Cherry";
            string replaced = coctail.Replace("+","and");
            Console.WriteLine(replaced);

            string number = "123456789";
            string removed = number.Remove(3,3);
            Console.WriteLine(removed);

            
        }
    }
}
