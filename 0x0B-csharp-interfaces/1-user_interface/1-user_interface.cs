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
  int durability{ 
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
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    public void Interact(){}
    public void Break(){}
    public void Collect(){}
}