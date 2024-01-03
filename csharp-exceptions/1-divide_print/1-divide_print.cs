using System;
using System.Collections.Generic;

class Int
{
	public static void divide(int a, int b)
	{
		int div = 0;
		try
		{
			div = a / b;
		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("Cannot divide by zero");
			return;
		}
		finally
		{
			Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + div.ToString());
		}
	}
}