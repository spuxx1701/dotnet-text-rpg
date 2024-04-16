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
    Interface.WriteLine("Du verlässt das Wirtshaus. Das Spiel ist vorbei.");
    player.EndGame();
  }
}