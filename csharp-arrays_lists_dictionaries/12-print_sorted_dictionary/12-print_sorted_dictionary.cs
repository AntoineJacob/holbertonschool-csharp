using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> newList = new SortedList<string, string>(myDict);

        foreach (var item in newList.Keys)
        {
            Console.WriteLine(item + ": " + newList[item]);
        }
    }
}