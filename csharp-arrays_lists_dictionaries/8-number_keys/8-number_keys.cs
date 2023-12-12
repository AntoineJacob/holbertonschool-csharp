using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static int NumberOfKeys(Dictionary<string, string> myDict)
        {
            int NumberOfKeys = 0;
            foreach (var key in myDict)
            {
                NumberOfKeys++;
            }
            return NumberOfKeys;
        }
    }