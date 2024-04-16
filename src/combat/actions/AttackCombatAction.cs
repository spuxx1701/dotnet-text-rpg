public class AttackCombatAction : CombatAction
{
  public override string ActionName
  {
    get
    {
      return "Angreifen";
    }
  }

  public override void Perform(CombatGameState combatGameState)
  {
    Interface.WriteLine("Welchen Gegner möchtest Du angreifen?");
    Enemy[] aliveEnemies = combatGameState.enemies.Where(enemy => enemy.IsAlive).ToArray();
    string[] targetOptions = aliveEnemies.Select(enemy => $"{enemy.Name} (HP: {enemy.CurrentHealth}/{enemy.MaxHealth})").ToArray();
    int targetSelection = Interface.AskForSelection(targetOptions);
    Enemy selectedTarget = aliveEnemies[targetSelection];
    combatGameState.player.Attack(selectedTarget);
  }
}