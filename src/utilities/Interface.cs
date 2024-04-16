public static class Interface
{
  public static void WriteLine(string message, ConsoleColor textColor = ConsoleColor.Gray, ConsoleColor? backgroundColor = null)
  {
    Console.ForegroundColor = textColor;
    if (backgroundColor != null) Console.BackgroundColor = (ConsoleColor)backgroundColor;
    Console.WriteLine(message);
    Console.ResetColor();
  }

  public static int AskForSelection(string[] options)
  {
    while (true)
    {
      ShowOptions(options);
      string? input = Console.ReadLine();
      if (int.TryParse(input, out int selection))
      {
        // If it worked
        bool isValidSelection = selection >= 0 && selection < options.Length;
        if (isValidSelection)
        {
          string output = $"Deine Auswahl: [{selection}] {options[selection]}";
          int outputLength = output.Length;
          string separator = $"+{new string('-', outputLength - 2)}+";
          // If the selection is valid
          Interface.WriteLine(separator, ConsoleColor.DarkGray);
          Interface.WriteLine(output, ConsoleColor.DarkGray);
          Interface.WriteLine(separator, ConsoleColor.DarkGray);
          return selection;
        }
        else
        {
          // If the selection isn't valid
          Interface.WriteLine($"⚠ Bitte gib eine Zahl zwischen 0 und {options.Length - 1} ein. ⚠", ConsoleColor.Red);
          continue;
        }
      }
      else
      {
        // If it didn't work
        Interface.WriteLine("⚠ Bitte gib eine Zahl ein. ⚠", ConsoleColor.Red);
        continue;
      }
    }
  }

  private static void ShowOptions(string[] options)
  {
    Interface.WriteLine("Triff eine Auswahl:");
    for (int i = 0; i < options.Length; i++)
    {
      string option = options[i];
      Interface.WriteLine($"[{i}] {option}", ConsoleColor.Yellow);
    }
  }
}