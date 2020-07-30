using System;

/// <summary> Class Player </summary>
public class Player {
  private string name;
  private float maxHp;
  private float hp;

  /// <summary> Constructor to set value </summary>
  /// <param name="name"> Player's Name </param>
  /// <param name="maxHp"> Max health </param>
  public Player (string name = "Player", float maxHp = 100f) {
    if (maxHp <= 0f) {
      Console.WriteLine ("maxHp must be greater than 0. maxHp set to 100f by default.");
      this.maxHp = 100f;
    } else
      this.maxHp = maxHp;
    this.name = name;
    this.hp = this.maxHp;
  }

  /// <summary> Method to print default values </summary>
  public void PrintHealth () {
    Console.WriteLine ("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
  }

  /// <summary> Check the damage </summary>
  /// <param name="damage"> Amount of damage </param>
  public void TakeDamage (float damage) {
    if (damage < 0f)
      damage = 0f;
    Console.WriteLine ("{0} takes {1} damage!", this.name, damage);
  }

  /// <summary> Check heal </summary>
  /// <param name="heal"> Amount of heal </param>
  public void HealDamage (float heal) {
    if (heal < 0f)
      heal = 0f;
    Console.WriteLine ("{0} heals {1} HP!", this.name, heal);
  }
}

/// <summary> Delegate CalculateHealth </summary>
/// <param name="amount"> Float amount </param>
public delegate void CalculateHealth (float amount);