public abstract class Enemy
{
  protected int _currentHealth;
  public abstract string Name { get; }
  public abstract int MaxHealth { get; }
  public abstract int CurrentHealth { get; set; }
  public abstract int MaxDamage { get; }
  public abstract int MinDamage { get; }

  public Boolean IsAlive
  {
    get
    {
      return this.CurrentHealth > 0;
    }
  }

  public Enemy()
  {
    this.CurrentHealth = this.MaxHealth;
  }

  public void TakeDamage(int damage)
  {
    this.CurrentHealth = CurrentHealth - damage;
    Interface.WriteLine($"Du greifst {this.Name} an und verursachst {damage} Schadenspunkte.", 500);
    if (this.IsAlive == false)
    {
      Interface.WriteLine($"Du hast {this.Name} besiegt!", 500);
    }
  }

  public void Attack(Player target)
  {
    Random rand = new Random();
    int damageDealt = rand.Next(this.MinDamage, this.MaxDamage + 1);
    target.TakeDamage(damageDealt, this);
  }
}