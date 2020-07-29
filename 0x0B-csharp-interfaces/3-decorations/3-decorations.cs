using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Abstract Class </summary>
public abstract class Base {

  /// <summary> Name of the object </summary>
  public string name;

  /// <summary> override ToString </summary>
  /// <returns> the object name and its type </returns>
  public override string ToString () {
    return $"{name} is a {this.GetType()}";
  }
}

interface IInteractive {
  void Interact ();
}

interface IBreakable {
  int durability {
    get;
    set;
  }
  void Break ();
}

interface ICollectable {
  bool isCollected {
    get;
    set;
  }
  void Collect ();
}

/// <summary> Class that inherits </summary>
class Door : Base, IInteractive {
  public Door (string name = "Door") => this.name = name;

  /// <summary>Implement the interface</summary>
  public void Interact () {
    Console.WriteLine ("You try to open the {0}. It's locked.", name);
  }
}

/// <summary>Implement the Base and interfaces</summary>
class Decoration : Base, IInteractive, IBreakable {
  public bool isQuestItem;
  public int durability { get; set; }

  public Decoration (string name = "Decoration", int durability = 1, bool isQuestItem = false) {

    if (durability <= 0)
      throw new Exception ("Durability must be greater than 0");

    this.name = name;
    this.durability = durability;
    this.isQuestItem = isQuestItem;
  }

  public void Interact () {
    if (durability <= 0)
      Console.WriteLine ("The {0} has been broken.", name);
    else if (isQuestItem == true)
      Console.WriteLine ("You look at the {0}. There's a key inside.", name);
    else
      Console.WriteLine ("You look at the {0}. Not much to see here.", name);
  }

  public void Break () {
    durability = durability - 1;
    if (durability > 0)
      Console.WriteLine ("You hit the {0}. It cracks.", name);
    else if (durability == 0)
      Console.WriteLine ("You smash the {0}. What a mess.", name);
    else if (durability < 0)
      Console.WriteLine ("The {0} is already broken.", name);
  }
}