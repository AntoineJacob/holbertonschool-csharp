using System;
using System.Collections.Generic;

namespace MyMath
{
	/// <summary>Contains multiple methods for calculating</summary>
    public class Operations
    {
		/// <summary>Method that takes a list and return the max number</summary>
		/// <returns>Max number</returns>
		public static int Max(List<int> nums)
		{
			if (nums.Count == 0 || nums == null)
				return 0;

			int MaxNum = nums[0];

			for (int i = 0; i < nums.Count; i++)
			{
				if (MaxNum < nums[i])
					MaxNum = nums[i];
			}
			return MaxNum;
		}
    }
}