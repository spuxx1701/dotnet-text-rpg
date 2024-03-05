public class BarGameState : GameState
{
  public override string ActionName
  {
    get
    {
      return "Zur Theke gehen";
    }
  }

  public override void Start(Player player)
  {
    Console.WriteLine("Du gehst zur Theke.");
    Console.WriteLine("[TODO: Hier Dialog & Handelsgameplay mit Gastwirt implementieren.]");
  }
}