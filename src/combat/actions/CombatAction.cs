public abstract class CombatAction
{
  public abstract string ActionName { get; }

  public abstract void Perform(CombatGameState combatGameState);
}