namespace ConsoleStuff;

/// <summary>
/// Handles the journal main menu.
/// </summary>
public class JournalMainMenu : Menu {

    /// <summary>
    /// Constructor.
    /// </summary>
    public JournalMainMenu() {
        this.menuItems = new Dictionary<int, Command>() {
            {0, new ExitCommand(this)},
            {1, new ListJournalEntriesCommand(this)},
            {2, new CreateJournalEntryCommand(this)},
        };
    }
}
