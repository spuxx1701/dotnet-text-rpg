public class CombatGameState : GameState
{
  public Player player;
  public Enemy[] enemies = DetermineEnemies();
  public bool playerIsFleeing = false;


  public override string ActionName
  {
    get
    {
      return "Jemanden zum Raufen suchen";
    }
  }

  public override void Start(Player player)
  {
    this.player = player;
    Interface.WriteLine("Du suchst Dir jemanden zum Raufen. Du triffst auf folgende raufwillige Gegner:");
    Boolean atLeastOneEnemyAlive = true;
    while (atLeastOneEnemyAlive)
    {
      this.DisplayEnemies();
      if (this.playerIsFleeing)
      {
        Interface.WriteLine("Du bist erfolgreich geflohen. Du Feigling!");
        return;
      }
      StartCombatRound();
      atLeastOneEnemyAlive = enemies.Any(enemy => enemy.IsAlive);
    }
    Interface.WriteLine("Du hast alle Gegner besiegt. Reschbeggt!");
  }

  private void StartCombatRound()
  {
    StartPlayerTurn();
    StartEnemyTurn();
  }

  private void StartPlayerTurn()
  {
    Interface.WriteLine($"Deine Lebenspunkte: ({player.CurrentHealth}/{player.MaxHealth})", ConsoleColor.Green);
    CombatAction[] availableActions = [new AttackCombatAction(), new FleeCombatAction()];

    string[] actionOptions = availableActions.Select(action => action.ActionName).ToArray();
    int actionSelection = Interface.AskForSelection(actionOptions);

    CombatAction selectedAction = availableActions[actionSelection];
    selectedAction.Perform(this);
  }

  private void StartEnemyTurn()
  {
    if (this.playerIsFleeing) return;
    Enemy[] enmiesThatCanAttack = enemies.Where(enemy => enemy.IsAlive).ToArray();
    foreach (Enemy enemy in enmiesThatCanAttack)
    {
      enemy.Attack(player);
    }
  }

  static public Enemy[] DetermineEnemies()
  {
    // Create an array of enemy types
    Type[] enemyTypes = [typeof(BrawlerEnemy), typeof(DogEnemy), typeof(WhoreEnemy)];

    // Create a list to hold the selected enemies. We need to use List because arrays in c# have a fixed size.
    List<Enemy> selectedEnemies = new List<Enemy>();

    // Create a new instance of Random
    Random rand = new Random();

    int numberOfEnemies = rand.Next(1, 4);
    for (int i = 0; i < numberOfEnemies; i++)
    {
      // Generate a random index to choose from EnemyTypes
      int index = rand.Next(enemyTypes.Length);

      // Use the index to get a random enemy type from the array
      Type selectedType = enemyTypes[index];

      // Create a new instance of the selected enemy type. This is a replacement for new selectedType()
      Enemy selectedEnemy = (Enemy)Activator.CreateInstance(selectedType);

      if (selectedEnemy != null)
      {
        selectedEnemies.Add(selectedEnemy);
      }
    }

    return selectedEnemies.ToArray();
  }

  public void DisplayEnemies()
  {
    for (int i = 0; i < enemies.Length; i++)
    {
      Enemy enemy = enemies[i];
      if (enemy.IsAlive)
      {
        Interface.WriteLine($"{enemy.Name} (HP: {enemy.CurrentHealth}/{enemy.MaxHealth})", ConsoleColor.Red);
      }
      else
      {
        Interface.WriteLine($"{enemy.Name} 💀", ConsoleColor.DarkRed);
      }

    }
  }
}