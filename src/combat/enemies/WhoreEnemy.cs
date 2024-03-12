public class WhoreEnemy : Enemy
{
  public override string Name
  {
    get
    {
      return "Heiße Schlämp";
    }
  }
  public override int MaxDamage
  {
    get
    {
      return 10;
    }
  }
  public override int MinDamage
  {
    get
    {
      return 0;
    }
  }
  public override int MaxHealth
  {
    get
    {
      return 12;
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