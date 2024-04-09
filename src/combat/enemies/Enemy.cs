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
    Console.WriteLine($"Du greifst {this.Name} an und verursachst {damage} Schadenspunkte.");
    if (this.IsAlive == false)
    {
      Console.WriteLine($"Du hast {this.Name} besiegt!");
    }
  }
}