﻿﻿using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class implementing IEnumerable.
/// </summary>
/// <typeparam name="T"></typeparam>
class Objs<T> : IEnumerable<T> {

    List<T> objs = new List<T> ();

    /// <summary>
    /// Adds an object to the generic list.
    /// </summary>
    public void Add(T newObj) {
        objs.Add(newObj);
    }

    // Implementation of generic IEnumerator interface.
    public IEnumerator<T> GetEnumerator() {

        for (int i = 0; i < objs.Count; i++)  
        {  
            yield return objs[i];  
        }  
    }

    // IEnumerator must also be implemented because IEnumerator<T> implements it.
    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }

}


/// <summary>
/// Defines a key.
/// </summary>
class Key : Base, ICollectable {

    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false) {

        this.name = name;
        this.isCollected = isCollected;

    }

    public void Collect() {

        if (isCollected == false) {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        } else {
            Console.WriteLine($"You have already picked up the {name}.");
        }

    }
}


/// <summary>
/// Defines a decoration in the game environment.
/// </summary>
class Decoration : Base, IInteractive, IBreakable {

    public bool isQuestItem { get; set; }
    public int durability { get; set; }  

    public Decoration(string name = "Decoration", int durability = 1,
                       bool isQuestItem = false) {

        if (durability <= 0) {
            throw new Exception("Durability must be greater than 0");
        } else {
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }

    }

    public void Interact() {

        if (durability <= 0) {
            Console.WriteLine($"The {name} has been broken.");
        } else if (isQuestItem == true) {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        } else {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }

    }

    public void Break() {

        durability--;

        if (durability > 0) {
            Console.WriteLine($"You hit the {name}. It cracks.");
        } else if (durability == 0) {
            Console.WriteLine($"You smash the {name}. What a mess.");
        } else {
            Console.WriteLine($"The {name} is already broken.");
        }

    }
}


/// <summary>
/// Defines an interactable door.
/// </summary>
class Door : Base, IInteractive {

    public Door(string _name = "Door") {
        name = _name;
    }

    public void Interact() {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }

}

/// <summary>
/// A base class.
/// </summary>
abstract class Base {

    public string name { get; set; }

    /// <summary>
    /// Convert the object to a string.
    /// </summary>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }

}

/// <summary>
/// Interface defining an interactable object.
/// </summary>
public interface IInteractive {

    /// <summary>
    /// Interact with this object.
    /// </summary>
    void Interact();

}

/// <summary>
/// Interface defining a breakable object.
/// </summary>
public interface IBreakable {

    /// <summary>
    /// The durability of the breakable object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break this object.
    /// </summary>
    void Break();

}

/// <summary>
/// Interface defining a collectable object.
/// </summary>
public interface ICollectable {

    /// <summary>
    /// Denotes whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect this object.
    /// </summary>
    void Collect();

}