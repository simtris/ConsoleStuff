using ConsoleStuff.Commands.Journal;

namespace ConsoleStuff.Menus.Journal;

/// <summary>
/// Handles the journal main menu.
/// </summary>
public class JournalMainMenu : Menu
{

    /// <summary>
    /// Constructor.
    /// </summary>
    public JournalMainMenu()
    {
        this.menuItems = new Dictionary<int, Command>() {
            {0, new ExitMenuCommand(this)},
            {1, new OpenJournalEntryCommand(this)},
            {2, new CreateJournalEntryCommand(this)},
        };
    }
}
