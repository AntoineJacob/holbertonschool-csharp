﻿using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 0; i <= 99; i++)
            {
                if (i < 99)
                {
                   Console.Write($"{i:D2}, ");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }


            }
        }
    }
}
