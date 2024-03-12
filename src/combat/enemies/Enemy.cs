public abstract class Enemy
{
  protected int _currentHealth;
  public abstract string Name { get; }
  public abstract int MaxHealth { get; }
  public abstract int CurrentHealth { get; set; }
  public abstract int MaxDamage { get; }
  public abstract int MinDamage { get; }

  public Enemy()
  {
    this.CurrentHealth = this.MaxHealth;
  }
}