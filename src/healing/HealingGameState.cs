public class HealingGameState : GameState
{
  public override string ActionName
  {
    get
    {
      return "Ans Feuer setzen";
    }
  }

  public override void Start(Player player)
  {
    Interface.WriteLine("Du setzt Dich ans Feuer und ruhst Dich aus.");
    int regeneratedHealth = player.MaxHealth - player.CurrentHealth;
    player.CurrentHealth = player.MaxHealth;
    Interface.WriteLine($"Du fühlst Dich ausgeruht. Du hast {regeneratedHealth} Lebenspunkte wiederhergestellt. Du stehst wieder auf.");
  }
}