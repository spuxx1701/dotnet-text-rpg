public class Weapon
{
  public string Name;
  public int MinDamage;
  public int MaxDamage;

  public Weapon(string name, int minDamage, int maxDamage)
  {
    this.Name = name;
    this.MinDamage = minDamage;
    this.MaxDamage = maxDamage;
  }
}