namespace ConsoleStuff;

/// <summary>
/// Handles the journal menu.
/// </summary>
public class JournalMenu : Menu {

    /// <summary>
    /// Constructor.
    /// </summary>
    public JournalMenu() {
        this.menuItems = new Dictionary<int, Command>() {
            {0, new NewJournalEntryCommand(this)},
            {1, new ListJournalEntryCommand(this)},
            {2, new ExitCommand(this)}
        };
    }
}
