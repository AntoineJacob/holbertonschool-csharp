using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            myLList.AddLast(i);
        }
        foreach (int item in myLList)
        {
            Console.WriteLine(item);
        }
        return myLList;
    }
}