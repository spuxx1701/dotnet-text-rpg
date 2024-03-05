public class Player
{
  public string Name;
  public PlayerClass Class;
  public Origin Origin;
  public int MaxHealth;
  public int CurrentHealth;
  public Weapon EquippedWeapon;

  public Player(string name, PlayerClass selectedClass, Origin origin)
  {
    this.Name = name;
    this.Class = selectedClass;
    this.Origin = origin;
    this.MaxHealth = origin.BaseHealth;
    this.CurrentHealth = origin.BaseHealth;
    this.EquippedWeapon = selectedClass.StarterWeapon;
  }
}