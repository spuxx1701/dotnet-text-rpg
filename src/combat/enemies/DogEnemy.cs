public class DogEnemy : Enemy
{
  public override string Name
  {
    get
    {
      return "Hund";
    }
  }
  public override int MaxDamage
  {
    get
    {
      return 4;
    }
  }
  public override int MinDamage
  {
    get
    {
      return 2;
    }
  }
  public override int MaxHealth
  {
    get
    {
      return 10;
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