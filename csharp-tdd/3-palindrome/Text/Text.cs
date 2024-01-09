﻿using System;
using System.Text.RegularExpressions;

namespace Text
{
	/// <summary>Contains multiple methods to evaluate strings.</summary>
    public class Str
    {
		/// <summary>Cleans a string by removing special characters</summary>
		/// <returns>return a string without any special character.</returns>
		public static string CleanString(string s)
		{
			string result = Regex.Replace(s, @"[^A-Za-z0-9]", "");
			return result;
		}

		/// <summary>Check if a string is palindrome</summary>
		/// <returns>return true if the string is palindrome, false otherwise</returns>
		public static bool IsPalindrome(string s)
		{
			// Clean the string by removing special characters
			string Result = CleanString(s.ToLower());

			// turn result into an array and reverse it
			char[] CharArray = Result.ToCharArray();
			Array.Reverse(CharArray);

			// turn reversed into a string
			string Reversed = new String(CharArray);

			// check if the result is equal to the reversed string
			if (Result.Equals(Reversed))
				return true;

			return false;
		}
    }
}