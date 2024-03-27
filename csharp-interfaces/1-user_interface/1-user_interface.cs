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
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	/// <summary>
	/// int property for durability 
	/// </summary>
	public int durability {get; set; }
	/// <summary>
	/// bool property for isCollected
	/// </summary>
	public bool isCollected { get; set; }

	/// <summary>
	/// Interact method
	/// </summary>
	public void Interact()
	{

	}

	/// <summary>
	/// Break method
	/// </summary>
	public void Break()
	{

	}

	/// <summary>
	/// Collect method
	/// </summary>
	public void Collect()
	{

	}
}