﻿using System;
/// <summary>
/// New generic list Queue of type T
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    public Type CheckType()
    {
        return typeof(T);
    }
}