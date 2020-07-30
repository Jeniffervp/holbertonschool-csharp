using System;

/// <summary> Class Player </summary>
public class Player
{
  private string name;
  private float maxHp;
  private float hp;

  /// <summary> Constructor to set value </summary>
  /// <param name="name"> Player's Name </param>
  /// <param name="maxHp"> Max health </param>
  public Player(string name = "Player", float maxHp = 100f)
  {
    if (maxHp <= 0)
    {
      this.maxHp = 100f;
      Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
    }
    else
      this.maxHp = maxHp;

    this.hp = this.maxHp;
    this.name = name;
  }

  /// <summary> Print default val </summary>
  public void PrintHealth()
  {
    Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
  }
}
