namespace ConsoleStuff;

/// <summary>
/// Command to create a new journal entry
/// </summary>
public class NewJournalEntryCommand : Command {

    /// <summary>
    /// Constructor.
    /// </summary>
    public NewJournalEntryCommand(Menu menu) {
        this.menu = menu;
    }
    
    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "New journal entry";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute() {
        string fileName = DateTime.Now.ToString("yyyyMMdd_HHmm") + ".txt";
        string fullPath = Path.Combine(Constants.journalFolderPath, fileName);
        File.WriteAllText(fullPath, string.Empty);

        using StreamWriter writer = new(fullPath);
        while (true) {
            
            string? input = Console.ReadLine();
            if (input == null) continue;
            if (input == "!wq") break;

            writer.WriteLine(input);
            writer.WriteLine(); // Blank line between inputs
        }
    }
}
