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
    Interface.WriteLine("Du versuchst zu fliehen.");
    Random rand = new Random();
    combatGameState.playerIsFleeing = rand.Next(0, 2) == 1;
    if (!combatGameState.playerIsFleeing)
    {
      Interface.WriteLine("Deine Gegner lassen Dich nicht davonkommen!");
    }
  }
}