using ConsoleStuff.Commands.Journal;

namespace ConsoleStuff;

/// <summary>
/// Handles the main menu.
/// </summary>
public class MainMenu : Menu {

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainMenu() : base("Main Menu") {
        this.menuItems[1] = new OpenJournalMainMenuCommand(this);
    }
}
