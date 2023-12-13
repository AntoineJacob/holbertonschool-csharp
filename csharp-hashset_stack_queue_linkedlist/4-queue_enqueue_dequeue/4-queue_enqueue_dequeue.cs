using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool searchInList = false;

        Console.WriteLine("Number of items: " + aQueue.Count);
        if (aQueue.Count < 1)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: " + aQueue.Peek());
        }
        foreach (string item in aQueue)
        {
            if (item == search)
            {
                searchInList = true;
            }
        }
        if (!searchInList)
            Console.WriteLine("Queue contains \"" + search + "\": False");
        else
        {
            Console.WriteLine("Queue contains \"" + search + "\": True");
            while (aQueue.Dequeue() != search)
                ;
        }
        
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}