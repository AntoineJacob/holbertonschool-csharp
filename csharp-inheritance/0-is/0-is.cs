using System;
using System.Collections.Generic;

/// <summary>
/// Class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// Method who return True if obj is int
    /// </summary>

    public static bool IsOfTypeInt(object obj)
    {
        return(obj is int);
    }
}

