namespace ConsoleStuff.Commands.Journal;

/// <summary>
/// Command to display the content of a journal entry
/// </summary>
public class DisplayJournalEntryCommand : Command
{

    /// <summary>
    /// The path of the file for this journal entry
    /// </summary>
    private readonly string journalEntryFilePath;

    /// <summary>
    /// Constructor.
    /// </summary>
    public DisplayJournalEntryCommand(Menu menu, string journalEntryFilePath)
    {
        this.menu = menu;
        this.journalEntryFilePath = journalEntryFilePath;
    }

    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => Path.GetFileNameWithoutExtension(this.journalEntryFilePath);

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute()
    {
        Console.Clear();
        if (File.Exists(this.journalEntryFilePath))
        {
            string content = File.ReadAllText(journalEntryFilePath);
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File not found: " + journalEntryFilePath);
        }
        Console.ReadLine();
    }
}
