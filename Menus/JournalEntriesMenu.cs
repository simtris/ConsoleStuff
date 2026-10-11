namespace ConsoleStuff;

/// <summary>
/// Handles the journal entry list menu.
/// </summary>
public class JournalEntriesMenu : Menu {

    /// <summary>
    /// Constructor.
    /// </summary>
    public JournalEntriesMenu() {
        this.menuItems = [];
        this.menuItems[0] = new ExitCommand(this);
        
        string[] files = Directory.GetFiles(Constants.journalFolderPath, "*.txt");
        for (int i = 0; i < files.Length; i++) {
            this.menuItems[i + 1] = new DisplayJournalEntryCommand(this, files[i].Split("\\").Last());
        }
    }
}
