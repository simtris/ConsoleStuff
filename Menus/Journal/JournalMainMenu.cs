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
    public JournalMainMenu() : base("Journal Menu") { 
        this.menuItems[1] = new OpenJournalEntryCommand(this);
        this.menuItems[2] = new CreateJournalEntryCommand(this);
    }
}
