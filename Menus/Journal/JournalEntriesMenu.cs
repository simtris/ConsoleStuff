using ConsoleStuff.Commands.Journal;

namespace ConsoleStuff.Menus.Journal;

/// <summary>
/// Handles the journal entry list menu.
/// </summary>
public class JournalEntriesMenu : Menu
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public JournalEntriesMenu(string name, Func<Menu, string, Command> actionOnSelect) : base(name) {
        string[] files = Directory.GetFiles(Constants.journalFolderPath, "*.txt");
        for (int i = 0; i < files.Length; i++)
        {
            this.menuItems[i + 1] = actionOnSelect.Invoke(this, files[i]);
        }
    }
}
