public abstract class GameState
{
  public abstract string ActionName { get; }

  public abstract void Start(Player player);
}