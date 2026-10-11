namespace ConsoleStuff;

/// <summary>
/// Command to display a journal entry
/// </summary>
public class DisplayJournalEntryCommand : Command {

    /// <summary>
    /// The name of the file for this journal entry
    /// </summary>
    private readonly string journalEntryFileName;

    /// <summary>
    /// Constructor.
    /// </summary>
    public DisplayJournalEntryCommand(Menu menu, string journalEntryFileName) {
        this.menu = menu;
        this.journalEntryFileName = journalEntryFileName;
    }
    
    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => this.journalEntryFileName;

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute() {
        Console.Clear();
        string fullPath = Path.Combine(Constants.journalFolderPath, this.journalEntryFileName);

        if (File.Exists(fullPath)) {
            string content = File.ReadAllText(fullPath);
            Console.WriteLine(content);
        } else {
            Console.WriteLine("File not found: " + fullPath);
        }
        Console.ReadLine();
    }
}
