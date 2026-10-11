namespace ConsoleStuff;

/// <summary>
/// Command to list the existing journal entries
/// </summary>
public class ListJournalEntryCommand : Command {

    /// <summary>
    /// Constructor.
    /// </summary>
    public ListJournalEntryCommand(Menu menu) {
        this.menu = menu;
    }
    
    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "List journal entries";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute() {
        string[] files = Directory.GetFiles(Constants.journalFolderPath, "*.txt");
        Console.WriteLine("Existing journal entries:");
        foreach (string file in files) {
            Console.WriteLine(file);
        }
    }
}
