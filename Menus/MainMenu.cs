using ConsoleStuff.Commands.Journal;

namespace ConsoleStuff;

/// <summary>
/// Handles the main menu.
/// </summary>
public class MainMenu : Menu {

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainMenu() {
        this.menuItems = new Dictionary<int, Command>() {
            {0, new ExitMenuCommand(this)},
            {1, new OpenJournalMainMenuCommand(this)},
        };
    }
}
