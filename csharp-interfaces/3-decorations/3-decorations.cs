﻿using System;
using System.Collections;

/// <summary>Interface 1 - interactive</summary>
interface IInteractive
{
	void Interact();
}

/// <summary>Interface 2 - breakable</summary>
interface IBreakable
{
	int durability { get; set; }
	void Break();
}

/// <summary>Interface 3 - collectable</summary>
interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

/// <summary>abstract class base</summary>
public abstract class Base
{
	/// <summary>public property name</summary>
	public string name { get; set; }

	/// <summary>Method override ToString</summary>
	/// <returns>The value of name and his type</returns>
	public override string ToString()
	{
		return name + $" is a " + this.GetType().Name;
	}
}

/// <summary>inherit class from base with 3 interfaces implementation</summary>
public class Door : Base, IInteractive
{
	/// <summary>
	/// Constructor for door
	/// </summary>
	/// <param name="name">name</param>
	public Door(string name = "Door")
	{
		this.name = name;
	}

	/// <summary>
	/// interact metho from interactive interface
	/// </summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}

}
/// <summary>inherit class Decoration from base with 2 interfaces implementation</summary>
public class Decoration : Base, IInteractive, IBreakable
{
	/// <summary>isQuestItem property</summary>
	public bool isQuestItem { get; set; }
	/// <summary>durability property</summary>
	public int durability { get; set; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="name">name variable from base class</param>
	/// <param name="durability">durability property from Ibreakable interface</param>
	/// <param name="isQuestItem">isQuestItem property from this class</param>
	/// <exception cref="Exception">throw exception if durability are less or equal to 0</exception>
	public Decoration (string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;

		if (durability <= 0)
			throw new Exception("Durability must be greather than 0");
	}

	/// <summary>Interact method implementation from IInteractive interface</summary>
	public void Interact()
	{
		if (durability <= 0)
			Console.WriteLine($"The {name} has been broken.");
		else
			if (isQuestItem) 
				Console.WriteLine($"You look at the {name}. There's a key inside.");
			else
				Console.WriteLine($"You look at the {name}. Not much to see here.");
	}

	/// <summary>Break method implementation from IBreakable interface</summary>
	public void Break()
	{
		durability--;

		if (durability > 0)
			Console.WriteLine($"You hit the {name}. It cracks.");
		else if (durability == 0)
			Console.WriteLine($"You smash the {name}. What a mess.");
		else
			Console.WriteLine($"The {name} is already broken.");
	}
}