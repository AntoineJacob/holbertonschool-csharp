﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        else
        {
            int maxNumber = myList[0];
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > maxNumber)
                {
                    maxNumber = myList[i];
                }
            }

                return maxNumber;
        }
    }
}