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
    Console.WriteLine("Du triffst auf folgende raufwillige Gegner:");
    this.DisplayEnemies(enemies);
    Console.WriteLine("[TODO: Hier Combat Gameplay implementieren.]");
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
    foreach (Enemy enemy in enemies)
    {
      Console.WriteLine(enemy.Name);
    }
  }
}