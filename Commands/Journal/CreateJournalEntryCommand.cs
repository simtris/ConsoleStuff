namespace ConsoleStuff.Commands.Journal;

/// <summary>
/// Command to create a new journal entry
/// </summary>
public class CreateJournalEntryCommand : Command
{

    /// <summary>
    /// Constructor.
    /// </summary>
    public CreateJournalEntryCommand(Menu menu)
    {
        this.menu = menu;
    }

    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "Create Journal Entry";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute()
    {
        string fileName = DateTime.Now.ToString("yyyyMMdd_HHmm") + ".txt";
        string fullPath = Path.Combine(Constants.journalFolderPath, fileName);
        File.WriteAllText(fullPath, string.Empty);

        using StreamWriter writer = new(fullPath);
        Console.Clear();
        Console.WriteLine("Enter !wq to save and quit entry.");
        while (true)
        {

            string? input = Console.ReadLine();
            if (input == null) continue;
            if (input == "!wq") break;

            writer.WriteLine(input);
            writer.WriteLine(); // Blank line between inputs
        }
    }
}
