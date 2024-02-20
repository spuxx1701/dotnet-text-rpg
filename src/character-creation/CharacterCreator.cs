public static class CharacterCreator
{
  public static Player CreatePlayer()
  {
    Console.WriteLine("Wie heißt Du, mutiger Held?");
    string? playerName = Console.ReadLine();
    if (playerName == null || string.IsNullOrWhiteSpace(playerName))
    {
      playerName = "Bimbatz";
      Console.WriteLine("Du hast nichts eingegeben! Wir nennen Dich einfach " + playerName + ".");
    }
    Console.WriteLine("Willkommen, " + playerName + "!");

    // Let the player choose what class they want to play
    string[] availableClasses = ["Magier", "Ritter", "Mönch", "Schurke", "Barde", "Druide"];
    int classSelection = Interface.AskForSelection(availableClasses);
    string selectedClass = availableClasses[classSelection];
    Console.WriteLine("Du bist ein " + selectedClass + ".");

    // Let the player pick an origin
    Origin[] availableOrigins = [new Origin("Mensch", "Mittelreich", 30), new Origin("Elf", "Waldreich", 25), new Origin("Zwerg", "Bergreich", 35), new Origin("Halbling", "Auenland", 25), new Origin("Ork", "Dunkeltal", 32)];
    string[] originOptions = availableOrigins.Select(origin => $"Rasse: {origin.Race}, Herkunft: {origin.Homeland}, HP: {origin.BaseHealth}").ToArray();
    int originSelection = Interface.AskForSelection(originOptions);
    Origin selectedOrigin = availableOrigins[originSelection];
    Console.WriteLine("Du bist ein " + selectedOrigin.Race + " aus dem " + selectedOrigin.Homeland + ".");

    // Create the player
    Player player = new Player(playerName, selectedClass, selectedOrigin);
    return player;
  }
}