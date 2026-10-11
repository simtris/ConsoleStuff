using ConsoleStuff.Menus.Journal;

namespace ConsoleStuff.Commands.Journal;

/// <summary>
/// Command to list the existing journal entries
/// </summary>
public class ListJournalEntriesCommand : Command
{

    /// <summary>
    /// Constructor.
    /// </summary>
    public ListJournalEntriesCommand(Menu menu)
    {
        this.menu = menu;
    }

    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "List journal entries";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute()
    {
        var journalEntriesMenu = new JournalEntriesMenu();
        journalEntriesMenu.Open();
    }
}
