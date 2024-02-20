public class Player
{
  public string Name;
  public string Class;
  public Origin Origin;
  public int MaxHealth;
  public int CurrentHealth;

  public Player(string name, string selectedClass, Origin origin)
  {
    this.Name = name;
    this.Class = selectedClass;
    this.Origin = origin;
    this.MaxHealth = origin.BaseHealth;
    this.CurrentHealth = origin.BaseHealth;
  }
}