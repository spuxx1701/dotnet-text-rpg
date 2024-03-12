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
    Console.WriteLine("Du setzt Dich ans Feuer und ruhst Dich aus.");
    int regeneratedHealth = player.MaxHealth - player.CurrentHealth;
    player.CurrentHealth = player.MaxHealth;
    Console.WriteLine($"Du fühlst Dich ausgeruht. Du hast {regeneratedHealth} Lebenspunkte wiederhergestellt. Du stehst wieder auf.");
  }
}