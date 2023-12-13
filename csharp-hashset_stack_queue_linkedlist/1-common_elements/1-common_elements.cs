using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{
		List<int> myList = list1.FindAll(element => list2.Contains(element));
		return myList;
	}
}