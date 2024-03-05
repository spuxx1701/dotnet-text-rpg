public class ExitGameState : GameState
{
  public override string ActionName
  {
    get
    {
      return "Das Wirtshaus verlassen (Spiel beenden)";
    }
  }

  public override void Start(Player player)
  {
    Console.WriteLine("Du verlässt das Wirtshaus. Das Spiel ist vorbei.");
    Console.WriteLine("+++ Game stats +++");
    Console.WriteLine($"Deine Lebenspunkte: {player.CurrentHealth}");
    Console.WriteLine($"Besiegte Gegner: {player.DefeatedEnemies}");
    Console.WriteLine("++++++++++++++++++");
    Environment.Exit(0);
  }
}