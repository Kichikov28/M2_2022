﻿using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int course = n / p;
            int ost = n % p;
            if (ost>0)
            {
                course++;

            }
            Console.WriteLine(course);
            //int kurs=
            
            //else 
            //{

            //}
        }
    }
}
