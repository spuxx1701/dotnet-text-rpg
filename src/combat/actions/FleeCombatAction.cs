public class FleeCombatAction : CombatAction
{
  public override string ActionName
  {
    get
    {
      return "Fliehen";
    }
  }

  public override void Perform(CombatGameState combatGameState)
  {
    Interface.WriteLine("Du versuchst zu fliehen.", 0);
    Random rand = new Random();
    combatGameState.playerIsFleeing = rand.Next(0, 2) == 1;
    if (!combatGameState.playerIsFleeing)
    {
      Interface.WriteLine("Deine Gegner lassen Dich nicht davonkommen!", 0);
    }
  }
}