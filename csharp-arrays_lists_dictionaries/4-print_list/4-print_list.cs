﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size > 0)
        {
            List<int> myList = new List<int>(size);
            int listL = myList.Count;
            for (int j = 0; j < size; j++)
            {
                if (j == size - 1)
                {
                    Console.WriteLine($"{j}");
                }
                else
                {
                    Console.Write($"{j} ");
                }

            }
            for (int i = 0; i < size; i++)
            {
                myList.Add(i);
            }
            return myList;
        }
        else if (size == 0)
        {
            Console.WriteLine("");
            List<int> myList = new List<int>(size);
            return myList;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
    }
}