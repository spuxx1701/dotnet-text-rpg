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
    Interface.WriteLine("Du gehst zur Theke.", ConsoleColor.Cyan);
    Interface.WriteLine($"Der Wirt spricht: \"Du hast {player.DefeatedEnemies} Gegner besiegt.\"", ConsoleColor.Cyan);
    if (player.DefeatedEnemies == 0)
    {
      Interface.WriteLine("Der Wirt lacht laut. \"Du Schwächling, so wirst du nie Respekt erlangen!\"", ConsoleColor.Cyan);
    }
    else if (player.DefeatedEnemies >= 1 && player.DefeatedEnemies <= 10)
    {
      Interface.WriteLine($"Der Wirt schmunzelt. \"Gar nicht mal so übel, du hast dir schon einen Namen gemacht, {player.Name}.\"", ConsoleColor.Cyan);
    }
    else
    {
      Interface.WriteLine($"Der Wirt staunt. \"Alle Achtung! Mit dir legt man sich besser nicht an, {player.Name}.\"", ConsoleColor.Cyan);
    }
  }
}