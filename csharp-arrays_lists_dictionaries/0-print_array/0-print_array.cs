﻿using System;

public static class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size > 0)
        {
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                int arrayLenght = Array.Length;
                if (i < arrayLenght - 1)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
            return Array;
        }
        else if (size == 0)
        {
            Console.WriteLine("");
            int[] Array = new int[size];
            return Array;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

    }
}