﻿using System;

namespace _5_DectoHexanBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            var hex = Convert.ToString(dec, 16).ToUpper();
            var bin = Convert.ToString(dec, 2);
            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
