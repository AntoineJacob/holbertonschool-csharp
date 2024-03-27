﻿using System;

/// <summary>generic list Queue of type T</summary>
/// <typeparam name="T">generic type</typeparam>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count = 0;

    /// <summary>method for check type of T</summary>
    /// <returns>type of T</returns>
    public Type CheckType()
    {
        return typeof(T);
    }


    public class Node
    {
        /// <summary>class for object Node</summary>
        public T value = default(T);
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>method for add a node to Queue object</summary>
    /// <param name="p">value of the node</param>
    public void Enqueue(T p)
    {
        Node n = new Node(p); 

        if (head == null)
        {
            head = n;
            tail = n;
        }
        else
        {
            tail.next = n;
            tail = n;
        }
        count++;
    }

    /// <summary>method for remove node in the queue</summary>
    /// <returns>default value if queue empty, else value removed</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }

    /// <summary>method for remove node in the queue</summary>
    /// <returns>default value if queue empty, else value removed</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    /// <summary>new method for know number of node inside queue object</summary>
    /// <returns>number of node</returns>
    public int Count()
    { return count; }
}