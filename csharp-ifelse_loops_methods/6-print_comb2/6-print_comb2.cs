﻿using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int k = 1;

            for (i = 0; i <= 9; i++)
            {
                for (int j = k; j <= 9; j++)
                {
                    if (i < 8)
                    {
                        Console.Write(i);
                        Console.Write($"{j}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
                k++;
            }
        }
    }
}
