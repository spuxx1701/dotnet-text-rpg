Interface.WriteLine("Willkommen bei 'Zum Goldenen Rammler', einem Text-Rollenspiel!", 0);
Player player = CharacterCreator.CreatePlayer();
Interface.WriteLine("Das Spiel beginnt! Du betrittst das Wirtshaus 'Zum Goldenen Rammler'.", 1000);

while (true)
{
  Interface.WriteLine("+-------------------------------------------+", 0, ConsoleColor.DarkGray);
  Interface.WriteLine("Du stehst im Schankraum. Was möchtest Du tun?", 0);
  Interface.WriteLine($"Deine Lebenspunkte: ({player.CurrentHealth}/{player.MaxHealth})", 0, ConsoleColor.Green);
  // Let the player choose what they want to do
  GameState[] availableGameStates = [new BarGameState(), new CombatGameState(), new HealingGameState(), new ExitGameState()];
  string[] gameStateOptions = availableGameStates.Select(gameState => gameState.ActionName).ToArray();
  int gameStateSelection = Interface.AskForSelection(gameStateOptions);
  GameState selectedGameState = availableGameStates[gameStateSelection];

  // Start the selected game state
  selectedGameState.Start(player);
}
