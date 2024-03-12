public class BrawlerEnemy : Enemy
{
  public override string Name
  {
    get
    {
      return "Schläger";
    }
  }
  public override int MaxDamage
  {
    get
    {
      return 5;
    }
  }
  public override int MinDamage
  {
    get
    {
      return 1;
    }
  }
  public override int MaxHealth
  {
    get
    {
      return 15;
    }
  }
  public override int CurrentHealth
  {
    get
    {
      return this._currentHealth;
    }
    set
    {
      this._currentHealth = value;
    }
  }
}