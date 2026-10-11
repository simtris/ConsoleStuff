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
            {0, new ListJournalEntriesCommand(this)},
            {1, new NewJournalEntryCommand(this)},
            {2, new ExitCommand(this)}
        };
    }
}
