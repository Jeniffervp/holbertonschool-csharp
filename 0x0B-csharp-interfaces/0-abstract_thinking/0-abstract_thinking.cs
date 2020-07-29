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