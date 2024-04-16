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
    int damageDealt = rand.Next(this.EquippedWeapon.MinDamage, this.EquippedWeapon.MaxDamage + 1);
    target.TakeDamage(damageDealt);
    if (target.IsAlive == false)
    {
      this.DefeatedEnemies++;
    }
    return damageDealt;
  }

  public void TakeDamage(int damage, Enemy attacker)
  {
    this.CurrentHealth = this.CurrentHealth - damage;
    Interface.WriteLine($"{attacker.Name} greift Dich an! Du erhälst {damage} Schadenspunkte.");
    this.CheckDeath();
  }

  public void CheckDeath()
  {
    if (this.CurrentHealth <= 0)
    {
      Interface.WriteLine("Du bist tot!");
      this.EndGame();
    }
  }

  public void EndGame()
  {
    Interface.WriteLine("+---------+ Game Over +---------+", ConsoleColor.Magenta);
    Interface.WriteLine($"Dein Held: {this.Name}, {this.Class.Name} und {this.Origin.Race} aus dem {this.Origin.Homeland}");
    Interface.WriteLine($"Besiegte Gegner: {this.DefeatedEnemies}");
    Interface.WriteLine("+-------------------------------+", ConsoleColor.Magenta);
    Environment.Exit(0);
  }
}