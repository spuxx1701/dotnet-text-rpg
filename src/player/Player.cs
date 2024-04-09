public class Player
{
  public string Name;
  public PlayerClass Class;
  public Origin Origin;
  public int MaxHealth;
  public int CurrentHealth;
  public Weapon EquippedWeapon;
  public int DefeatedEnemies = 0;

  public Player(string name, PlayerClass selectedClass, Origin origin)
  {
    this.Name = name;
    this.Class = selectedClass;
    this.Origin = origin;
    this.MaxHealth = origin.BaseHealth;
    this.CurrentHealth = origin.BaseHealth;
    this.EquippedWeapon = selectedClass.StarterWeapon;
  }

  public int Attack(Enemy target)
  {
    Random rand = new Random();
    int damageDealt = rand.Next(this.EquippedWeapon.MinDamange, this.EquippedWeapon.MaxDamage + 1);
    target.TakeDamage(damageDealt);
    if (target.IsAlive == false)
    {
      this.DefeatedEnemies++;
    }
    return damageDealt;
  }
}