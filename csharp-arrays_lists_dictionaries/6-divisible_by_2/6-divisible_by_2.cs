﻿using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        int lengthMyList = myList.Count;
        List<bool> listB = new List<bool>(new bool[lengthMyList]);

        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                listB[i] = true;
            }
            else
            {
                listB[i] = false;
            }
        }
        return listB;
    }
}