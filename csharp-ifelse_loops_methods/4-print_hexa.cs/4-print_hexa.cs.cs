﻿using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 98; i++)
            {
                Console.WriteLine($"{i} = 0x{i:x}");
            }
        }
    }
}
