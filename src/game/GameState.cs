public abstract class GameState
{
  public abstract string ActionName { get; }

  public abstract void Start(Player player);

  public void EndGameState()
  {
    Interface.WriteLine("Drücke eine beliebige Taste, um zum Schankraum zurückzukehren.", 1000, ConsoleColor.DarkGray);
    Console.ReadKey();
  }
}