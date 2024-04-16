public static class CharacterCreator
{
  public static Player CreatePlayer()
  {
    Interface.WriteLine("Wie heißt Du, mutiger Held?", 1000, ConsoleColor.Yellow);
    string? playerName = Console.ReadLine();
    if (playerName == null || string.IsNullOrWhiteSpace(playerName))
    {
      playerName = "Bimbatz";
      Interface.WriteLine("Du hast nichts eingegeben! Wir nennen Dich einfach " + playerName + ".", 0);
    }
    Interface.WriteLine("Willkommen, " + playerName + "!", 0);

    // Let the player pick an origin
    Interface.WriteLine("Woher kommst Du?", 1000);
    Origin[] availableOrigins = [new Origin("Mensch", "Mittelreich", 30), new Origin("Elf", "Waldreich", 25), new Origin("Zwerg", "Bergreich", 35), new Origin("Halbling", "Auenland", 25), new Origin("Ork", "Dunkeltal", 32)];
    string[] originOptions = availableOrigins.Select(origin => $"Rasse: {origin.Race}, Herkunft: {origin.Homeland}, HP: {origin.BaseHealth}").ToArray();
    int originSelection = Interface.AskForSelection(originOptions);
    Origin selectedOrigin = availableOrigins[originSelection];

    // Let the player choose what class they want to play
    Interface.WriteLine("Und was bist Du von Beruf?", 1000);
    Weapon[] starterWeapons = [new Weapon("Stab", 8, 12), new Weapon("Schwert", 5, 15)];
    PlayerClass[] availableClasses = [new PlayerClass("Ritter", starterWeapons[1]), new PlayerClass("Magier", starterWeapons[0]), new PlayerClass("Mönch", starterWeapons[0]), new PlayerClass("Schurke", starterWeapons[1])];
    string[] classOptions = availableClasses.Select(playerClass => $"{playerClass.Name}, Startwaffe: {playerClass.StarterWeapon.Name} (Schaden: {playerClass.StarterWeapon.MinDamage}-{playerClass.StarterWeapon.MaxDamage})").ToArray();
    int classSelection = Interface.AskForSelection(classOptions);
    PlayerClass selectedClass = availableClasses[classSelection];

    // Create the player
    Player player = new Player(playerName, selectedClass, selectedOrigin);
    Interface.WriteLine($"Du bist {player.Name}, ein {player.Origin.Race} aus dem {player.Origin.Homeland}. Deine Profession ist {player.Class.Name}.", 1000);
    return player;
  }
}