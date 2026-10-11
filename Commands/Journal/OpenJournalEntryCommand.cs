using ConsoleStuff.Menus.Journal;

namespace ConsoleStuff.Commands.Journal;

/// <summary>
/// Command to open a journal entry. First list all entries, then display the selected one.
/// </summary>
public class OpenJournalEntryCommand : Command
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public OpenJournalEntryCommand(Menu menu)
    {
        this.menu = menu;
    }

    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "Open Journal Entry";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute()
    {
        var journalEntriesMenu = new JournalEntriesMenu((menu, entryName) => new DisplayJournalEntryCommand(menu, entryName));
        journalEntriesMenu.Open();
    }
}
