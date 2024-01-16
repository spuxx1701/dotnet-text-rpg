public static class Interface
{
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
          // If the selection is valid
          Console.WriteLine($"Deine Auswahl: [{selection}] {options[selection]}");
          return selection;
        }
        else
        {
          // If the selection isn't valid
          Console.WriteLine($"⚠ Bitte gib eine Zahl zwischen 0 und {options.Length - 1} ein. ⚠");
          continue;
        }
      }
      else
      {
        // If it didn't work
        Console.WriteLine("⚠ Bitte gib eine Zahl ein. ⚠");
        continue;
      }
    }
  }

  private static void ShowOptions(string[] options)
  {
    Console.WriteLine("Triff eine Auswahl:");
    for (int i = 0; i < options.Length; i++)
    {
      string option = options[i];
      Console.WriteLine($"[{i}] {option}");
    }
  }
}