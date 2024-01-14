Console.WriteLine("Willkommen bei 'Zum Goldener Rammler', einem Text-Rollenspiel!");
Console.WriteLine("Wie heißt Du, mutiger Held?");
string? playerName = Console.ReadLine();
bool isPlayerNameEmpty = string.IsNullOrWhiteSpace(playerName);
if (isPlayerNameEmpty)
{
  playerName = "Bimbatz";
  Console.WriteLine("Du hast nichts eingegeben! Wir nenen Dich einfach " + playerName + ".");
}
Console.WriteLine("Willkommen, " + playerName + "!");

// Let the player choose what class they want to play
string[] availableClasses = ["Magier", "Ritter", "Mönch", "Schurke"];
Console.WriteLine("Wähle nun Deine Klasse. Die folgenden Klassen stehen zur Auswahl:");
for (int i = 0; i < availableClasses.Length; i++)
{
  string availableClass = availableClasses[i];
  Console.WriteLine("[" + i + "] " + availableClass);
}

// We now ask the player to pick a class
string? playerClassSelection = Console.ReadLine();
// We need to check whether the player has entered a valid class
if (int.TryParse(playerClassSelection, out int selection) && selection >= 0 && selection < availableClasses.Length)
{
  // Player did enter a valid number
  Console.WriteLine("Du bist ein " + availableClasses[selection] + ".");
}
else
{
  // Player did not enter a valid number
  Console.WriteLine("Ungültige Auswahl!");
  return;
}
