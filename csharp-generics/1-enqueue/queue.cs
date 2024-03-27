﻿using System;

/// <summary>New generic list Queue of type T</summary>
/// <typeparam name="T">generic type</typeparam>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count = 0;

    /// <summary>Method for check type of T</summary>
    /// <returns>type of T</returns>
    public Type CheckType()
    {
        return typeof(T);
    }


    public class Node
    {
        /// <summary>New class for object Node</summary>
        public T value = default(T);
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>new method for add a node to Queue object</summary>
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

    /// <summary>new method for know number of node inside queue object</summary>
    /// <returns>number of node</returns>
    public int Count()
    { return count; }
}