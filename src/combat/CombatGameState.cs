public class CombatGameState : GameState
{
  public override string ActionName
  {
    get
    {
      return "Jemanden zum Raufen suchen";
    }
  }

  public override void Start(Player player)
  {
    Console.WriteLine("Du suchst Dir jemanden zum Raufen.");
    Console.WriteLine("[TODO: Hier Combat Gameplay implementieren.]");
  }
}