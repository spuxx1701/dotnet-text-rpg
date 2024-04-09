public class CombatGameState : GameState
{
  public override string ActionName
  {
    get
    {
      return "Jemanden zum Raufen suchen";
    }
  }

  public override void Start(Player player)
  {
    Console.WriteLine("Du suchst Dir jemanden zum Raufen.");
    Enemy[] enemies = this.DetermineEnemies();
    this.DisplayEnemies(enemies);
    Boolean atLeastOneEnemyAlive = true;
    while (atLeastOneEnemyAlive)
    {
      StartCombatRound(player, enemies);
      atLeastOneEnemyAlive = enemies.Any(enemy => enemy.IsAlive);
    }
    Console.WriteLine("Du hast alle Gegner besiegt. Reschbeggt!");
  }

  private void StartCombatRound(Player player, Enemy[] enemies)
  {
    Console.WriteLine("Welchen Gegner möchtest Du angreifen?");
    Enemy[] aliveEnemies = enemies.Where(enemy => enemy.IsAlive).ToArray();
    string[] targetOptions = aliveEnemies.Select(enemy => $"{enemy.Name} (HP: {enemy.CurrentHealth}/{enemy.MaxHealth})").ToArray();
    int targetSelection = Interface.AskForSelection(targetOptions);
    Enemy selectedTarget = aliveEnemies[targetSelection];
    player.Attack(selectedTarget);
  }

  public Enemy[] DetermineEnemies()
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

  public void DisplayEnemies(Enemy[] enemies)
  {
    Console.WriteLine($"Du triffst auf folgende raufwillige Gegner: {string.Join(", ", enemies.Select(e => e.Name))}");
  }
}