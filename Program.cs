Console.WriteLine("Willkommen bei 'Zum Goldenen Rammler', einem Text-Rollenspiel!");
Player player = CharacterCreator.CreatePlayer();
Console.WriteLine("Das Spiel beginnt! Du betrittst das Wirtshaus 'Zum Goldenen Rammler'.");

while (true)
{
  Console.WriteLine("Du stehst im Schankraum. Was möchtest Du tun?");
  // Let the player choose what they want to do
  GameState[] availableGameStates = [new BarGameState(), new CombatGameState(), new ExitGameState()];
  string[] gameStateOptions = availableGameStates.Select(gameState => gameState.ActionName).ToArray();
  int gameStateSelection = Interface.AskForSelection(gameStateOptions);
  GameState selectedGameState = availableGameStates[gameStateSelection];

  // Start the selected game state
  selectedGameState.Start(player);
}
