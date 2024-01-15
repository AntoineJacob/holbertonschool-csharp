using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// method that prints the names of the
    /// available properties and methods of an object.
    /// </summary>
     public static void Print(object myObj)
    {
        var type = myObj.GetType();
        Console.WriteLine(type.Name + " Properties:");

        foreach (PropertyInfo property in type.GetProperties())
            Console.WriteLine(property.Name);
            
        Console.WriteLine(type.Name + " Methods:");

        foreach (MethodInfo method in type.GetMethods())
            Console.WriteLine(method.Name);
    }
}