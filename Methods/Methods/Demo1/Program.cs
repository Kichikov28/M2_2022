using System;

namespace Demo1
{
    class Program
    {
        static void student(string name, int age)
        {
            
            Console.WriteLine($"{name} is {age} years old");
        }
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            student(name,15);
        }
    }
}
