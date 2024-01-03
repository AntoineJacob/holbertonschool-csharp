using System;
using System.Collections.Generic;

public enum Rating
{
	Good,
	Great,
	Excellent
}

public struct Dog
{
	public string name;
	public float age;
	public string owner;
	public Rating rating;

	public Dog(string newname, float newage, string newowner, Rating newrating)
	{
		name = newname;
		age = newage;
		owner = newowner;
		rating = newrating;
	}
}