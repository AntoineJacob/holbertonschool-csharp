using System;
using System.Collections.Generic;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		LinkedListNode<int> node = myLList.First;
		if (index >= myLList.Count || index < 0)
		{
			return;
		}
		for (int i = 0; i < index; i++)
		{
			node = node.Next;
		}
		myLList.Remove(node);
	}
}