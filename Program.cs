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
string[] availableClasses = ["Magier", "Ritter", "Mönch", "Schurke", "Barde", "Druide"];
int classSelection = Interface.AskForSelection(availableClasses);
string selectedClass = availableClasses[classSelection];
Console.WriteLine("Du bist ein " + selectedClass + ".");

// // Let the player pick an origin
Origin[] availableOrigins = [new Origin("Mensch", "Mittelreich"), new Origin("Elf", "Waldreich"), new Origin("Zwerg", "Bergreich"), new Origin("Halbling", "Auenland"), new Origin("Ork", "Dunkeltal")];
// Transform our origins into a list of strings that we can pass to AskForSelection
string[] originOptions = availableOrigins.Select(origin => $"Rasse: {origin.Race}, Herkunft: {origin.Homeland}").ToArray();
int originSelection = Interface.AskForSelection(originOptions);
Origin selectedOrigin = availableOrigins[originSelection];
Console.WriteLine("Du bist ein " + selectedOrigin.Race + " aus dem " + selectedOrigin.Homeland + ".");